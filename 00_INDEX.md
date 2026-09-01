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

Limit: **20 files, 20 MB each**. This comes to 14.

| # | File | Covers requirement |
|---|---|---|
| 1 | `AI_Usage_Declaration.md` | 1 |
| 2 | `AI_Usage_Declaration.pdf` | 1 |
| 3 | `DEMO_VIDEOS.md` | 2 |
| 4 | `DEMO_VIDEOS.pdf` | 2 |
| 5 | `report.md` | 3 |
| 6 | `report.pdf` | 3 |
| 7 | `FEATURE_LIST.md` | 4 |
| 8 | `FEATURE_LIST.pdf` | 4 |
| 9 | `MEMBER_CONTRIBUTION.md` | 6 |
| 10 | `MEMBER_CONTRIBUTION.pdf` | 6 |
| 11 | `Member_contribution.xlsx` | 6 |
| 12-14 | `Group54_source.part1.rar` .. `part3.rar` | 5 |

Member contribution is submitted in all three forms: the spreadsheet the course
provides, plus the markdown and PDF that explain the division of work week by week and
justify the 50/50 split.

`00_INDEX.md` itself does not need uploading; it is a guide for the team.

---

## Packaging the source code

| Path | Size | Include? |
|---|---|---|
| `src/` | ~1 MB | Yes |
| `assets/` | 67 MB, ~43 MB after trimming | Yes |
| `CMakeLists.txt`, `.gitignore` | tiny | Yes |
| `build/` | **232 MB** | **No** - build output |
| `.git/` | **485 MB** | **No** |
| `Group54_*`, `*.html` | - | No - weekly reports and generated pages |

### Trim 24 MB of unused fonts first

`assets/fonts/` holds 25 MB but only `Courier_HintedSmooth.ttf` (788 KB) is referenced
anywhere in the source. The rest are unused, including `Arial Unicode MS Font.ttf` at
**22.2 MB**, which is also a proprietary Microsoft font that should not be redistributed.

Removing them takes `assets/` from 67 MB to about 43 MB, which is the difference between
a three-part and a four-part archive.

Checked before trimming: `vs_enemies2.png`, `vs_enemies3.png` and `vs_vfx.png` look
unused from the source but **are referenced from JSON data files**, so they stay.

### Build the archive

```bash
git archive --format=zip -o Group54_source.zip HEAD -- src assets CMakeLists.txt .gitignore
```

`git archive` exports tracked files only, so `build/`, `.git/` and untracked scratch files
are excluded automatically. Delete the unused fonts from inside the resulting zip.

Then split with WinRAR: right-click -> *Add to archive* -> **Split to volumes: 19 MB**,
giving about three parts.

### Verify before submitting

Extract the archive somewhere clean and build it:

```bash
cmake -S . -B build_check && cmake --build build_check
```

This matters more than usual for this project: a `CMakeLists.txt` case collision and 76
wrong-cased asset paths were fixed during the final week. A clean build from the packaged
copy is the only proof the archive actually works on another machine.

---

## Before submitting - checklist

- [ ] Both members read [`AI_Usage_Declaration.md`](AI_Usage_Declaration.md) and confirm the tool attribution
- [ ] Both members confirm the 50/50 split and the task hours
- [ ] Trim the unused fonts, build the archive, split it, and test a clean build
- [ ] Confirm the YouTube video is **Unlisted**, not Private, or the marker cannot open it
