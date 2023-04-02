## Randomizer for Elden Ring spirit ash summons.

![Capture](https://user-images.githubusercontent.com/55667610/161849780-02396cfa-7d6b-4c7a-8d81-33a83db09905.PNG)

## WARNINGS (PLEASE READ THIS PART)
- The current version of Mod Engine 2 does not manage save files, so if you have existing saves: go to "AppData\Roaming\EldenRing" and backup the save files within. Restore these backups before playing online, or you could potentially be banned.
- Do not run this tool on Regulation.bin in Elden Ring's "Game" folder. If you do and play online, you could potentially be banned.

## How to Use
- Download Mod Engine 2 https://github.com/soulsmods/ModEngine2/releases
- Copy "regulation.bin" from Elden Ring's "Game" folder to Mod Engine 2's "Mod" folder.
- Run Summon Randomizer. If the program doesn't run, you may need to install .NET 6.0 first.
- In the randomizer, browse and select "regulation.bin" within the Mod Engine 2's "Mod" folder.
- Change randomizer settings as desired. When you're ready, click "Randomize". After it's finished you can close it.
- Run Mod Engine 2's "launchmod_eldenring.bat" to play with mods.

## Updates
### v1.0.5
- Fixed empty SpEffect ID logic. This issue usually caused enemies to have modified stagger/poise behvaior, but it could also affect other misc things.
- Fixed program not working properly when launched from the start menu.

### v1.0.4
- Updated to work with Elden Ring v1.08

### v1.0.3
- Randomizer now creates output logs that lists RNG seed, settings preset, and randomization details.
- Fixed randomizer slightly modifying the AI of normal enemies that summons were copied from (exact effects are indeterminate and possibly nonexistent).
- Under the hood Settings Presets changes. Any future updates that include new settings will now update out-of-date settings presets and notify the user.

### v1.0.2
- Capped summon map collision radii (Prevents spawning in the ground. Incidentally lets them fit in small areas)
- Adjusted spawn offsets.
- Summons no longer retain NG+ scaling effects from whichever enemy they were copied from.
- Summons no longer drop runes.

### v1.0.1
- Added 'Balanced' preset. 
- Adjusted 'Reasonable' preset.
- Removed accidental bad tooltips for certain UI elements

### v1.0.0
Public Release
- Changed/fixed how multi-buddy spawn offsets are calculated
- Added a warning if you want to randomize a regulation.bin that already has a backup next to it
- Misc UI and text adjustments
- Included readme in download

### v0.1.0
Initial beta release

## Info
- Built using https://github.com/JKAnderson/SoulsFormats
- Contains Param Definitions from https://github.com/soulsmods/Paramdex
