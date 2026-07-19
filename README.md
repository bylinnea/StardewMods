# StardewMods

My [Stardew Valley](https://www.stardewvalley.net/) mods, made with love and a growing amount of C#. All released mods are on [my Nexus profile](https://www.nexusmods.com/profile/byLinnea).

| Mod | Type | What it does |
|---|---|---|
| [Useful Hats](UsefulHats/) | SMAPI (C#) | Gives every hat in the game a themed stat buff |
| [Slime Hutch Winery Interior](SlimeHutchWineryInterior/) | Content Patcher pack | Turns the Slime Hutch interior into a winery |

## Useful Hats

Makes every hat in the game actually do something. Each of the 121 obtainable vanilla hats gives a small themed stat buff while worn. The Fishing Hat helps you fish, the Hard Hat protects you in the mines, and the rarer the hat, the stronger the buff.

Buffs appear as a normal buff icon while the hat is worn and vanish the moment you take it off. Nothing is written to your save, so uninstalling is always safe.

Everything is configurable through `config.json`: rebalance any hat, or add entries for custom hats from other mods (wear a hat and press `F5` in-game to log its ID to the SMAPI console). See the [mod's own README](UsefulHats/README.md) for the full configuration guide.

**Requires:** Stardew Valley 1.6+, [SMAPI](https://smapi.io/) 4.0+

## Slime Hutch Winery Interior

A [Content Patcher](https://www.nexusmods.com/stardewvalley/mods/1915) pack that reskins the Slime Hutch interior as a cozy winery. Available on [Nexus](https://www.nexusmods.com/stardewvalley/mods/20156).

**Requires:** Stardew Valley, [SMAPI](https://smapi.io/), [Content Patcher](https://www.nexusmods.com/stardewvalley/mods/1915)

## Installation

1. Install [SMAPI](https://smapi.io/) (and Content Patcher for the winery mod).
2. Download the mod you want and unzip it into your `Stardew Valley/Mods` folder.
3. Launch the game through SMAPI.

To uninstall a mod, delete its folder from `Mods`.

## Repository layout

Each mod lives in its own folder with its `manifest.json`. Useful Hats is a C# project: open its folder and run `dotnet build`, and [ModBuildConfig](https://www.nuget.org/packages/Pathoschild.Stardew.ModBuildConfig) deploys it to your game automatically.

## Credits

- **ConcernedApe** for Stardew Valley
- **Pathoschild** for SMAPI, Content Patcher, and the mod build tooling
- The [Stardew Valley Wiki](https://stardewvalleywiki.com/) modding docs
