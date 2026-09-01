# CS202 Group 54 — Submission Index

**Project:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Members:** Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Repository:** https://github.com/NewFace819/CS202-VampireSurvivors-Project
**Due:** Thursday, 3 September 2026

---

## Documents, mapped to the submission requirements

| # | Requirement | Document | Status |
|---|---|---|---|
| 1 | AI Usage Declaration (Markdown + PDF) | [`AI_Usage_Declaration.md`](AI_Usage_Declaration.md) | Draft — **needs signatures** |
| 2 | Demo video links (all features / all levels) | [`DEMO_VIDEOS.md`](DEMO_VIDEOS.md) | Complete — [youtu.be/V-Nj_YRaE-0](https://youtu.be/V-Nj_YRaE-0) |
| 3 | Report (Markdown + PDF): class diagrams, design patterns, design reasoning | [`report.md`](report.md) | Complete — section 6 summarises the AI declaration |
| 4 | Feature list (40 × 0.25 pts = 10 pts) | [`FEATURE_LIST.md`](FEATURE_LIST.md) | Complete |
| 5 | Source code | `src/`, `assets/`, `CMakeLists.txt` | Complete — see packaging below |
| 6 | Member contribution | [`MEMBER_CONTRIBUTION.md`](MEMBER_CONTRIBUTION.md) | Complete — **evaluation form still to be filled in by the team** |

---

## Building the PDFs

```bash
python make_pdf.py report.md FEATURE_LIST.md MEMBER_CONTRIBUTION.md DEMO_VIDEOS.md AI_Usage_Declaration.md
```

That writes one `.html` per document. Open each and use **Ctrl+P → Save as PDF**
(margins Default, tick *Background graphics*).

To skip the manual step, print them headlessly:

```bash
"C:/Program Files/Google/Chrome/Application/chrome.exe" --headless --disable-gpu \
  --no-pdf-header-footer --virtual-time-budget=25000 \
  --print-to-pdf=report.pdf "file:///G:/CS202-VampireSurvivors-Project/report.html"
```

`pandoc` is **not** suitable here: the report contains 9 mermaid diagrams and LaTeX
math, which plain pandoc renders as raw code blocks and dropped text unless a filter
and a LaTeX engine are installed.

---

## Packaging the source code

The upload limit is **20 files, 20 MB each**.

| Path | Size | Include? |
|---|---|---|
| `src/` | ~1 MB | Yes |
| `CMakeLists.txt`, `.gitignore` | tiny | Yes |
| `assets/` | **67 MB** | Yes, but must be split |
| `build/` | large | **No** — build output |
| `Group54_*` | — | No — weekly reports |

67 MB of assets exceeds one file, so use the compress-and-split the brief mentions
(WinRAR → *Split to volumes*, 19 MB each → roughly 4 parts). Excluding `build/` is
essential; it is far larger than the assets.

Verify a clean build from the packaged copy before submitting:

```bash
cmake -S . -B build_check && cmake --build build_check
```

---

## Before submitting — checklist

- [ ] Both members sign [`AI_Usage_Declaration.md`](AI_Usage_Declaration.md) and confirm the tool attribution
- [ ] Both members confirm the 50/50 split in [`MEMBER_CONTRIBUTION.md`](MEMBER_CONTRIBUTION.md)
- [ ] Fill in the [evaluation form](https://tinyurl.com/httprojeval)
- [ ] Regenerate all PDFs after the edits above
- [ ] Package and split the source archive, then test a clean build
