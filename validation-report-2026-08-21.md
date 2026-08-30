# Main Regression Validation Report

Date: 2026-08-21
Status: Completed with one known source-audio limitation

## Canonical Gate

The expanded canonical validator passed all 10 checks:

- 64 source files are valid UTF-8, NFC-normalized, and BOM-free.
- No forbidden retired magnitude terminology remains.
- All declared power-42 copies use `Tredecillions`.
- All 1,540 Master Index records have unique, matching permanent IDs.
- Exponent 45+, `l` Drive, and G-Pulse semantic colour rules are canonical.
- The Master table and maintained Calculator copies match all 47 tiers.
- All 1,127 World Numerals rows are continuous, unique, and satisfy `e = 3n + 3`.
- Applied Systems retains 44 jumps, 287 pulses, and 900 zero positions.
- All 3 Calendar copies retain their canonical active-tier colours.
- All 30 Scroll Book copies load and apply the shared Neon Pink glyph protocol.

## Browser Regression

Passed:

- Calculator: `7,845,123 + 9 = 7,845,132`.
- Calculator: division by zero returns `Àṣìṣe` and `Kò ṣeé pín nípasẹ̀ òdo`.
- Converter: converts `7,845,132`, renders protocol glyph spans, and rejects `10,000,001`.
- Age Calculator: renders a completed age and rejects a future birth date.
- Calendar: date cells are selectable through accessible button semantics; month navigation works.
- Scroll Book 1, Volume 17: generated output renders 404 `l` Drive and 301 G-Pulse spans, all computed as Neon Pink `rgb(255, 19, 240)`.
- Talking Drum: 11 Gangan, 16 Shekere, and 4 Ilu Gbedu recordings decode and play without uncaught page errors.
- Talking Drum: missing variation slots retain their declared indexes and fall back safely; unavailable Omele exits without throwing.
- Talking Drum: its image and nonblank canvas render at desktop and mobile sizes without horizontal overflow.
- Desktop checks found no horizontal overflow in tested core apps.
- Mobile checks at 390 x 844 found no horizontal overflow on the home page, Numeric Products, Calculator, Converter, Calendar, or Scroll Book 1.
- All seven Numeric Products presentation images are present.
- The six declared Numeric Products download targets are present; Talking Drum now downloads as one self-contained offline HTML file.

## Known Audio Limitation

The supplied old Talking Drum folder contains 32 MP3 files. Of the 54 slots declared by the application, 31 files are used and decode successfully: 11 Gangan, 16 Shekere, and 4 Ilu Gbedu recordings. The extra `1 Gangan.mp3` file is not declared by the application.

The current package intentionally preserves all declared variation positions. Missing Gangan, Shekere, and Ilu Gbedu variations fall back to the first available recording without shifting later selections. Omele has no supplied recording and therefore remains silent, but no longer causes an `AudioBufferSourceNode` exception.

Completed packaging work:

1. Copied the supplied recordings and drum image beside the deployed application.
2. Built `GitHub/tools/Talking Drum Standalone.html` with 31 declared recordings and the drum image embedded as data URLs.
3. Changed the Numeric Products download link from the multi-file archive to the single offline HTML file.
4. Repaired missing-buffer indexing, unavailable-instrument handling, small-canvas drawing, and image-load race conditions in all three Talking Drum copies.
5. Opened the standalone file directly through `file:///` and reran audio, canvas, desktop, and mobile browser regression without a server.

Full four-instrument audio coverage still requires the original Omele recordings and the other missing variation files. The available supplied audio package passes its regression.

## Download Packaging

The public downloads now use a consistent release structure:

- Calculator, Converter, Age Calculator, Calendar, and Talking Drum ZIPs each contain exactly one standalone HTML file.
- Number Generator ZIP contains exactly ten standalone Scroll Book HTML files with their shared CSS and glyph protocol inlined.
- `GitHub/Yoruba Apps.zip` contains the five standalone applications offered by the index app-suite button.
- The index Scroll Books button uses the validated Number Generator archive; the unavailable Flip Book wording and missing archive target were removed.
- Converter and Age Calculator were opened from extracted local files, completed their primary workflows, and made no network requests.
- Calculator, Calendar, Number Generator, and Talking Drum were also opened and exercised from their extracted release files.

These archives can be rebuilt with `tools/build-app-downloads.ps1`.

## Notes

The Converter and Age Calculator use Tailwind CDN and in-browser Babel, which emit production-advisory console warnings but did not cause functional test failures.

VS Code's PowerShell analyzer continued to report two false-positive `$Matches` warnings on static `Regex.Matches` calls. The validator executes successfully and passes all 10 checks.
