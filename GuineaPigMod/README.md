# Guinea Pig Mod for Stardew Valley

## Brief Overview

A custom mod that adds adorable guinea pigs as a new coop animal to Stardew Valley. These cute rodents can be purchased from Marnie's shop and produce unique poop that can be crafted into fertilizer. Perfect for players who want a new animal companion with practical benefits!

## Detailed Description

./

## Features

- **Custom Guinea Pig Animal**: Adds guinea pigs as a new coop animal type
- **Custom Texture**: Unique guinea pig sprite
- **High Production**: Guinea pigs produce 7-8 poop piles per day
- **Crafting Recipes**: Use guinea pig poop to craft fertilizer
- **Proper Integration**: Uses HarmonyLib for seamless game integration

## Installation

1. Download the latest release zip file
2. Extract the `GuineaPigMod` folder to your Stardew Valley Mods directory
3. Ensure you have SMAPI installed
4. Launch the game

## Requirements

- Stardew Valley 1.6+
- SMAPI 3.0.0

## Crafting Recipes

Guinea pig poop can be used to craft different tiers of fertilizer:

### Basic Fertilizer (Agriculture Level 1)
- **Ingredients**: 1 Poop Pile + 1 Sap
- **Output**: 3 Basic Fertilizer
- **Unlock**: Available from the start
- **Use**: Basic crop quality improvement (3x more efficient than vanilla!)

### Quality Fertilizer (Agriculture Level 3)
- **Ingredients**: 2 Poop Piles + 1 Sap
- **Output**: 2 Quality Fertilizer
- **Unlock**: Requires Agriculture skill level 3
- **Use**: Better crop quality improvement (2x more efficient than vanilla!)

### Deluxe Fertilizer (Agriculture Level 6)
- **Ingredients**: 3 Poop Piles + 1 Sap
- **Output**: 1 Deluxe Fertilizer
- **Unlock**: Requires Agriculture skill level 6
- **Use**: Maximum crop quality improvement

*Note: All recipes require Sap as an additional ingredient, which can be collected from trees.*

## Development

This mod is built using:
- C# with .NET 6.0
- HarmonyLib for game patching
- SMAPI for mod framework

## License

Private project - not for distribution without permission.

## Version History

- **v1.1.6**: Babies now poop too! Ensured correct production settings in all data assets for full compatibility and consistency.
- **v1.1.5**: Increased guinea pig production to 7-8 poop piles per day
- **v1.1.3**: Improved recipe efficiency - now produces multiple fertilizer per craft
- **v1.1.2**: Fixed crafting recipe format to use item names instead of IDs
- **v1.1.1**: Improved debug logging to only show guinea pig asset requests
- **v1.1.0**: Added crafting recipes for fertilizer using guinea pig poop
  - Basic Fertilizer (Agriculture Level 1): 1 Poop Pile + 1 Sap
  - Quality Fertilizer (Agriculture Level 3): 2 Poop Piles + 1 Sap
  - Deluxe Fertilizer (Agriculture Level 6): 3 Poop Piles + 1 Sap
- **v1.0.14**: Updated sprite dimensions and animation frame settings
- **v1.0.13**: Updated sprite dimensions for 7-row layout
- **v1.0.12**: Added texture variants support
- **v1.0.11**: Fixed Harmony patching issues
- **v1.0.10**: Initial release with basic guinea pig functionality 