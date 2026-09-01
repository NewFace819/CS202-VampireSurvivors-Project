# CS202 Group 54 — Submission Index

**Project:** Vampire Survivors Clone (C++20 / SFML 2.6)
**Members:** Do Gia Huy (25125013), Vo Thanh Hai (25125011)
**Repository:** https://github.com/NewFace819/CS202-VampireSurvivors-Project
**Due:** Thursday, 3 September 2026

---

## Documents, mapped to the submission requirements

| # | Requirement | Document | Status |
|---|---|---|---|
| 1 | AI Usage Declaration (Markdown + PDF) | [`AI_Usage_Declaration.md`](AI_Usage_Declaration.md) | Complete |
| 2 | Demo video links (all features / all levels) | [`DEMO_VIDEOS.md`](DEMO_VIDEOS.md) | Complete — [youtu.be/V-Nj_YRaE-0](https://youtu.be/V-Nj_YRaE-0) |
| 3 | Report (Markdown + PDF): class diagrams, design patterns, design reasoning | [`report.md`](report.md) | Complete — section 6 summarises the AI declaration |
| 4 | Feature list (40 × 0.25 pts = 10 pts) | [`FEATURE_LIST.md`](FEATURE_LIST.md) | Complete |
| 5 | Source code | `src/`, `assets/`, `CMakeLists.txt` | Complete — see packaging below |
| 6 | Member contribution | [`MEMBER_CONTRIBUTION.md`](MEMBER_CONTRIBUTION.md) + `Member_contribution.xlsx` | Complete — 20 tasks, 120 hours, verified |

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

## What to upload

Limit: **20 files, 20 MB each**. This comes to 13, all within the size limit.

| # | File | Size | Covers |
|---|---|---|---|
| 1 | `AI_Usage_Declaration.md` | small | req 1 |
| 2 | `AI_Usage_Declaration.pdf` | 234 KB | req 1 |
| 3 | `DEMO_VIDEOS.md` | small | req 2 |
| 4 | `DEMO_VIDEOS.pdf` | 92 KB | req 2 |
| 5 | `report.md` | small | req 3 |
| 6 | `report.pdf` | 391 KB | req 3 |
| 7 | `FEATURE_LIST.md` | small | req 4 |
| 8 | `FEATURE_LIST.pdf` | 163 KB | req 4 |
| 9 | `MEMBER_CONTRIBUTION.md` | small | req 6 |
| 10 | `MEMBER_CONTRIBUTION.pdf` | 174 KB | req 6 |
| 11 | `Member_contribution.xlsx` | small | req 6 |
| 12 | `Group54_source.zip` | **11.3 MB** | req 5 |
| 13 | `HOW_TO_BUILD.md` | small | helps the marker run req 5 |

Member contribution is submitted in all three forms: the course spreadsheet, plus the
markdown and PDF that explain the week-by-week division and justify the 50/50 split.

`00_INDEX.md` is a guide for the team and does not need uploading.

---

## The source archive

**`Group54_source.zip` is 11.3 MB — one file, no splitting.** Rebuild it with:

```bash
git archive --format=zip -o _raw.zip HEAD -- src assets CMakeLists.txt .gitignore
```

then drop the unused fonts and images (see below) from the result.

`git archive` exports tracked files only, so `build/` (232 MB) and `.git/` (485 MB) are
excluded automatically.

### What was excluded, and why it is safe

| Excluded | Size | Reason |
|---|---|---|
| 9 font files | 24 MB | Only `Courier_HintedSmooth.ttf` is referenced anywhere. `Arial Unicode MS Font.ttf` alone is 22 MB and is a proprietary Microsoft font that should not be redistributed. |
| `vs_vfx.png` | 5.2 MB | Byte-identical to `assets/Graphics/Spritesheets/vfx.png`, which is the copy the code loads. |
| `vs_enemies2.png`, `vs_enemies3.png` | 6.8 MB | Referenced only from `assets/data/enemies/*.json`, which the code never loads -- it loads `assets/data/enemies.json`. |

Kept despite looking unused: `vs_enemies.png`, which **is** referenced directly from the
source.

### Verification performed

1. All 128 asset path literals in `src/` were checked against the archive contents: every
   one resolves.
2. The archive was extracted to a clean folder, configured, and built from scratch.
3. The resulting executable was launched and ran.

That third step caught a real bug: the old `POST_BUILD` step used
`cmd /C ... mklink /J`, and because CMake paths use forward slashes, `cmd.exe` read
`C:/Temp/...` as the switch `/Temp` and aborted. It never showed locally because the
junction already existed. **Every clean build of this project failed before that fix**
(commit `6876b4ff`).

---

## Before submitting - checklist

- [ ] Both members read [`AI_Usage_Declaration.md`](AI_Usage_Declaration.md) and confirm the tool attribution
- [ ] Both members confirm the 50/50 split and the task hours
- [x] Source archive built, trimmed and verified with a clean build and run
- [ ] Confirm the YouTube video is **Unlisted**, not Private, or the marker cannot open it
