#!/usr/bin/env python3
"""
Render a Markdown file to a print-ready HTML page.

Usage:   python make_pdf.py report.md
Output:  report.html  -- open it in a browser and use Ctrl+P > "Save as PDF".

Why not pandoc: the report contains mermaid diagrams and LaTeX math. Plain pandoc
renders mermaid fences as raw code blocks and drops the math unless a filter and a
LaTeX engine are installed. This script renders both in the browser instead, and
needs nothing installed beyond Python itself.

Requires an internet connection on first open (marked / mermaid / KaTeX load from CDN).
"""
import io
import os
import sys

CSS = """
:root { --fg:#24292f; --muted:#57606a; --border:#d0d7de; --bg:#fff; --code-bg:#f6f8fa; }
* { box-sizing: border-box; }
body {
  font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Helvetica, Arial, sans-serif;
  font-size: 15px; line-height: 1.6; color: var(--fg); background: var(--bg);
  max-width: 900px; margin: 0 auto; padding: 40px 45px;
}
h1, h2, h3, h4 { line-height: 1.25; margin-top: 1.6em; margin-bottom: .6em; font-weight: 600; }
h1 { font-size: 2em; border-bottom: 1px solid var(--border); padding-bottom: .3em; }
h2 { font-size: 1.5em; border-bottom: 1px solid var(--border); padding-bottom: .3em; }
h3 { font-size: 1.2em; }
p, ul, ol, table, pre, blockquote { margin: 0 0 1em; }
a { color: #0969da; text-decoration: none; }
code {
  font-family: ui-monospace, SFMono-Regular, "SF Mono", Consolas, monospace;
  font-size: 85%; background: var(--code-bg); padding: .2em .4em; border-radius: 6px;
}
pre { background: var(--code-bg); padding: 14px; border-radius: 6px; overflow: auto; }
pre code { background: none; padding: 0; font-size: 90%; }
table { border-collapse: collapse; width: 100%; display: block; overflow-x: auto; }
th, td { border: 1px solid var(--border); padding: 6px 12px; text-align: left; vertical-align: top; }
th { background: var(--code-bg); font-weight: 600; }
tr:nth-child(2n) td { background: #f6f8fa66; }
blockquote {
  border-left: 4px solid var(--border); padding: 0 1em; color: var(--muted); margin-left: 0;
}
img, svg { max-width: 100%; }
hr { border: 0; border-top: 1px solid var(--border); margin: 2em 0; }
.mermaid { background: #fff; text-align: center; margin: 1.2em 0; }

@media print {
  body { padding: 0; max-width: none; font-size: 11pt; }
  h1, h2, h3 { page-break-after: avoid; }
  table, pre, blockquote { page-break-inside: avoid; }
  /* Keep diagrams whole, but scale any that are taller than a page. Without the
     height cap, "page-break-inside: avoid" on an oversized diagram makes the
     printer emit a blank page and drop it entirely. */
  .mermaid { page-break-inside: avoid; }
  .mermaid svg { max-height: 8.5in; width: auto; height: auto; }
  a { color: inherit; }
  a[href^="http"]::after { content: " (" attr(href) ")"; font-size: 85%; color: var(--muted); }
}
"""

PAGE = """<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>__TITLE__</title>
<style>__CSS__</style>
<script src="https://cdn.jsdelivr.net/npm/marked/marked.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/mermaid@10/dist/mermaid.min.js"></script>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/katex@0.16.9/dist/katex.min.css">
<script defer src="https://cdn.jsdelivr.net/npm/katex@0.16.9/dist/katex.min.js"></script>
<script defer src="https://cdn.jsdelivr.net/npm/katex@0.16.9/dist/contrib/auto-render.min.js"></script>
</head>
<body>
<div id="out">Rendering...</div>
<script type="text/plain" id="src">__MARKDOWN__</script>
<script>
window.addEventListener('load', function () {
  var md = document.getElementById('src').textContent;

  // Pull mermaid fences out before markdown parsing so they are not escaped.
  var blocks = [];
  md = md.replace(/```mermaid\\n([\\s\\S]*?)```/g, function (_, code) {
    blocks.push(code);
    return '\\n@@MERMAID' + (blocks.length - 1) + '@@\\n';
  });

  // GitHub alert syntax ( > [!IMPORTANT] ) is not standard markdown; make it a heading.
  md = md.replace(/^> \\[!(\\w+)\\]\\s*$/gm, '> **$1**');

  marked.setOptions({ gfm: true, breaks: false });
  var html = marked.parse(md);

  // Emit empty placeholders and fill them via textContent. Injecting the diagram
  // source through innerHTML would let mermaid's own syntax be parsed as HTML --
  // class diagrams contain <<abstract>>, which the parser eats as a tag.
  html = html.replace(/<p>\\s*@@MERMAID(\\d+)@@\\s*<\\/p>/g, '<pre class="mermaid" data-idx="$1"></pre>');
  html = html.replace(/@@MERMAID(\\d+)@@/g, '<pre class="mermaid" data-idx="$1"></pre>');

  document.getElementById('out').innerHTML = html;

  document.querySelectorAll('.mermaid[data-idx]').forEach(function (el) {
    el.textContent = blocks[parseInt(el.getAttribute('data-idx'), 10)];
  });

  if (window.mermaid) {
    mermaid.initialize({ startOnLoad: false, theme: 'neutral' });
    mermaid.run({ querySelector: '.mermaid' });
  }
  if (window.renderMathInElement) {
    renderMathInElement(document.body, {
      delimiters: [
        { left: '$$', right: '$$', display: true },
        { left: '\\\\[', right: '\\\\]', display: true },
        { left: '$', right: '$', display: false }
      ],
      throwOnError: false
    });
  }
});
</script>
</body>
</html>
"""


def render(md_path):
    if not os.path.exists(md_path):
        print("error: %s not found" % md_path)
        return 1

    text = io.open(md_path, encoding="utf-8").read()

    # The markdown lives inside a <script> block, so the only sequence that can
    # break out of it is a literal closing script tag.
    text = text.replace("</script>", "<\\/script>")

    title = os.path.splitext(os.path.basename(md_path))[0]
    page = (PAGE
            .replace("__CSS__", CSS)
            .replace("__TITLE__", title)
            .replace("__MARKDOWN__", text))

    out_path = os.path.splitext(md_path)[0] + ".html"
    io.open(out_path, "w", encoding="utf-8", newline="").write(page)
    print("wrote %s" % out_path)
    print("  open it in a browser, then Ctrl+P > Destination: Save as PDF")
    print("  set Margins: Default and tick Background graphics")
    return 0


if __name__ == "__main__":
    targets = sys.argv[1:] or ["report.md", "AI_Usage_Declaration.md"]
    rc = 0
    for t in targets:
        rc |= render(t)
    sys.exit(rc)
