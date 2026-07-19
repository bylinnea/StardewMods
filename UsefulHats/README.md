# Useful Hats

A [Stardew Valley](https://www.stardewvalley.net/) mod that makes every hat in the game actually do something. Each of the 121 obtainable vanilla hats gives a small themed stat buff while worn. The Fishing Hat helps you fish, the Hard Hat protects you in the mines, and the Leprechaun Hat makes you lucky. The rarer the hat, the stronger the buff.

Buffs appear as a normal buff icon while the hat is worn and vanish the moment you take it off. Nothing is written to your save, so uninstalling is always safe.

## Requirements

- Stardew Valley 1.6+
- [SMAPI](https://smapi.io/) 4.0 or newer

No other mods required.

## Installation

1. Install [SMAPI](https://smapi.io/).
2. Download the latest release and unzip it into your `Stardew Valley/Mods` folder.
3. Launch the game through SMAPI. Put on a hat!

To uninstall, delete the `UsefulHats` folder from `Mods`.

## How it works

While you wear a hat that has stats defined, the mod keeps a single buff active whose effects match that hat. Swap hats and the buff swaps with you; take the hat off and it's gone. Buff stats can include Farming, Fishing, Mining, Foraging, Luck, Attack, Defense, Immunity, Speed, Max Stamina, and Magnetic Radius.

Balance follows a simple rarity budget: common shop and tailoring hats give about one point of value, achievement hats two, rare drops three, and the near-impossible endgame hats are deliberately strong. A handful of legendary hats (you'll know them when you find them) break the rules on purpose.

## Configuration

Everything lives in `config.json` (generated next to the mod's DLL on first launch). Each entry maps a hat ID to its stats:

```json
"55": { "Fishing": 2 },
"BucketHat": { "MaxStamina": 40 }
```

Any stat you omit defaults to 0. Change any value, add or remove hats, and restart the game to apply.

**Custom hats from other mods work too:** add an entry with the custom hat's ID and it gets a buff like any other. To find a hat's ID, wear it in-game and press `F5`. The ID is logged to the SMAPI console.

Note: `MaxStamina` is in raw energy points (20–40 is noticeable) and `MagneticRadius` is in pixels (one tile = 64). The other stats use small numbers like +1 or +2.

## Building from source

The mod is a standard SMAPI C# project. Clone the repo, open the folder in your IDE, and run `dotnet build`. [ModBuildConfig](https://www.nuget.org/packages/Pathoschild.Stardew.ModBuildConfig) finds your game install and deploys the mod automatically. A release zip is generated under `bin/Release` when building with `-c Release`.

## Credits

- **ConcernedApe** for Stardew Valley
- **Pathoschild** for SMAPI and the mod build tooling
- The [Stardew Valley Wiki](https://stardewvalleywiki.com/) modding docs and hat list
