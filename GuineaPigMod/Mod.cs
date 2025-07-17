using StardewModdingAPI;
using StardewModdingAPI.Events;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using StardewValley.GameData.FarmAnimals;
using StardewValley.GameData;
using HarmonyLib;

namespace GuineaPigMod
{
    public class Mod : StardewModdingAPI.Mod
    {
        public ModConfig Config { get; private set; }
        private Harmony harmony;
        public static Mod Instance { get; private set; }
        
        public override void Entry(IModHelper helper)
        {
            Instance = this;
            Config = helper.ReadConfig<ModConfig>();
            harmony = new Harmony(this.ModManifest.UniqueID);
            harmony.PatchAll();
            Monitor.Log("=== GUINEA PIG MOD STARTING ===", LogLevel.Info);
            Monitor.Log("Guinea Pig Coop Animal mod loaded!", LogLevel.Info);
            Monitor.Log($"Helper type: {helper.GetType().Name}", LogLevel.Info);
            // Only set up asset injection
            helper.Events.Content.AssetRequested += OnAssetRequested;
            Monitor.Log("AssetRequested event handler registered successfully", LogLevel.Info);
            Monitor.Log("=== GUINEA PIG MOD STARTUP COMPLETE ===", LogLevel.Info);
        }
        
        /// <summary>
        /// Handle asset requests for our custom objects
        /// </summary>
        private void OnAssetRequested(object sender, AssetRequestedEventArgs e)
        {
            Monitor.Log($"=== ASSET REQUESTED: {e.Name} ===", LogLevel.Info);
            Monitor.Log($"Asset type: {e.Name.GetType().Name}", LogLevel.Info);
            Monitor.Log($"Asset name without locale: {e.NameWithoutLocale}", LogLevel.Info);
            
            try
            {
                if (e.Name.IsEquivalentTo("Data/ObjectInformation"))
                {
                    Monitor.Log("Processing Data/ObjectInformation asset...", LogLevel.Info);
                    e.Edit(asset =>
                    {
                        Monitor.Log("Editing Data/ObjectInformation asset...", LogLevel.Info);
                        var data = asset.AsDictionary<int, string>().Data;
                        Monitor.Log($"Current ObjectInformation entries count: {data.Count}", LogLevel.Info);
                        
                        // Add poop pile object
                        var poopPileData = $"{AssetInjector.PoopPileName}/{AssetInjector.PoopPilePrice}/-300/Basic -26/{AssetInjector.PoopPileDescription}/true/true/0 0 0 0 0 0 0 0/PoopPile";
                        data[AssetInjector.PoopPileId] = poopPileData;
                        Monitor.Log($"Injected custom object into ObjectInformation: PoopPileId={AssetInjector.PoopPileId}", LogLevel.Info);
                        Monitor.Log($"Poop pile data: {poopPileData}", LogLevel.Info);
                        Monitor.Log($"ObjectInformation entries count after injection: {data.Count}", LogLevel.Info);
                    });
                }
                // Inject guinea pig animal with texture variants and shop icon into Data/FarmAnimals
                else if (e.Name.IsEquivalentTo("Data/FarmAnimals"))
                {
                    Monitor.Log("Processing Data/FarmAnimals asset...", LogLevel.Info);
                    e.Edit(asset =>
                    {
                        Monitor.Log("Editing Data/FarmAnimals asset...", LogLevel.Info);
                        var data = asset.AsDictionary<string, FarmAnimalData>().Data;
                        Monitor.Log($"Current FarmAnimals entries count: {data.Count}", LogLevel.Info);
                        Monitor.Log($"Existing FarmAnimals keys: {string.Join(", ", data.Keys.Take(10))}", LogLevel.Info);
                        
                        // Create a new FarmAnimalData instance for the guinea pig using the correct field names
                        var guineaPigEntry = new FarmAnimalData
                        {
                            DisplayName = "Guinea Pig",
                            House = "Coop",
                            PurchasePrice = 2000,
                            DaysToMature = 3,
                            Texture = "Mods/GuineaPigMod/assets/texture_1.png",
                            Sound = "guineapig",
                            ShopTexture = "Mods/GuineaPigMod/assets/gpicon.png",
                            CanGetPregnant = false,
                            DaysToProduce = 1,
                            ProduceOnMature = true,
                            HarvestType = FarmAnimalHarvestType.DigUp,
                            CanEatGoldenCrackers = true,
                            CanSwim = false,
                            BabiesFollowAdults = false,
                            GrassEatAmount = 2,
                            SellPrice = 1000,
                            SleepFrame = 12,
                            SpriteWidth = 32,
                            SpriteHeight = 36,
                            UseFlippedRightForLeft = false,
                            UseDoubleUniqueAnimationFrames = true,
                            Gender = FarmAnimalGender.Female
                        };
                        
                        var entryKey = "GuineaPigMod.GuineaPig";
                        data[entryKey] = guineaPigEntry;
                        Monitor.Log($"Injected guinea pig with variants and shop icon into Data/FarmAnimals.", LogLevel.Info);
                        Monitor.Log($"Entry key: {entryKey}", LogLevel.Info);
                        Monitor.Log($"FarmAnimals entries count after injection: {data.Count}", LogLevel.Info);
                        Monitor.Log($"FarmAnimals keys after injection: {string.Join(", ", data.Keys.Where(k => k.Contains("GuineaPig") || k.Contains("Pig")))}", LogLevel.Info);
                    });
                }
                // Also inject into Data/Animals for compatibility
                else if (e.Name.IsEquivalentTo("Data/Animals"))
                {
                    Monitor.Log("Processing Data/Animals asset...", LogLevel.Info);
                    e.Edit(asset =>
                    {
                        Monitor.Log("Editing Data/Animals asset...", LogLevel.Info);
                        var data = asset.AsDictionary<string, object>().Data;
                        Monitor.Log($"Current Animals entries count: {data.Count}", LogLevel.Info);
                        Monitor.Log($"Existing Animals keys: {string.Join(", ", data.Keys.Take(10))}", LogLevel.Info);
                        
                        var guineaPigEntry = new Dictionary<string, object>
                        {
                            ["Name"] = "Guinea Pig",
                            ["Type"] = "Coop",
                            ["Description"] = "A cute, squeaky rodent that loves hay and naps.",
                            ["Price"] = 2000,
                            ["DaysToMature"] = 3,
                            ["Sprite"] = "Mods/GuineaPigMod/assets/texture_1.png",
                            ["TextureVariants"] = new List<object>
                            {
                                "Mods/GuineaPigMod/assets/texture_1.png",
                                "Mods/GuineaPigMod/assets/texture_2.png",
                                "Mods/GuineaPigMod/assets/texture_3.png"
                            },
                            ["ShopIcon"] = "Mods/GuineaPigMod/assets/gpicon.png",
                            ["Sound"] = "guineapig",
                            ["Products"] = new List<object>
                            {
                                new Dictionary<string, object>
                                {
                                    ["Id"] = $"(O){AssetInjector.PoopPileId}",
                                    ["Chance"] = 1.0
                                }
                            },
                            ["Home"] = "Coop",
                            ["CanBePurchased"] = true
                        };
                        
                        var entryKey = "GuineaPigMod.GuineaPig";
                        data[entryKey] = guineaPigEntry;
                        Monitor.Log($"Injected guinea pig with variants and shop icon into Data/Animals.", LogLevel.Info);
                        Monitor.Log($"Entry key: {entryKey}", LogLevel.Info);
                        Monitor.Log($"Entry data: {System.Text.Json.JsonSerializer.Serialize(guineaPigEntry)}", LogLevel.Info);
                        Monitor.Log($"Animals entries count after injection: {data.Count}", LogLevel.Info);
                        Monitor.Log($"Animals keys after injection: {string.Join(", ", data.Keys.Where(k => k.Contains("GuineaPig") || k.Contains("Pig")))}", LogLevel.Info);
                    });
                }

                // Provide custom textures for the game/mods
                if (e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/texture_1.png"))
                {
                    Monitor.Log("Loading texture_1.png asset...", LogLevel.Info);
                    e.LoadFrom(() => Helper.ModContent.Load<Texture2D>("assets/texture_1.png"), AssetLoadPriority.Medium);
                    Monitor.Log("texture_1.png asset loaded successfully", LogLevel.Info);
                }
                if (e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/texture_2.png"))
                {
                    Monitor.Log("Loading texture_2.png asset...", LogLevel.Info);
                    e.LoadFrom(() => Helper.ModContent.Load<Texture2D>("assets/texture_2.png"), AssetLoadPriority.Medium);
                    Monitor.Log("texture_2.png asset loaded successfully", LogLevel.Info);
                }
                if (e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/texture_3.png"))
                {
                    Monitor.Log("Loading texture_3.png asset...", LogLevel.Info);
                    e.LoadFrom(() => Helper.ModContent.Load<Texture2D>("assets/texture_3.png"), AssetLoadPriority.Medium);
                    Monitor.Log("texture_3.png asset loaded successfully", LogLevel.Info);
                }
                if (e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/gpicon.png"))
                {
                    Monitor.Log("Loading gpicon.png asset...", LogLevel.Info);
                    e.LoadFrom(() => Helper.ModContent.Load<Texture2D>("assets/gpicon.png"), AssetLoadPriority.Medium);
                    Monitor.Log("gpicon.png asset loaded successfully", LogLevel.Info);
                }
                if (e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/poop_pile.png"))
                {
                    Monitor.Log("Loading poop_pile.png asset...", LogLevel.Info);
                    e.LoadFrom(() => Helper.ModContent.Load<Texture2D>("assets/poop_pile.png"), AssetLoadPriority.Medium);
                    Monitor.Log("poop_pile.png asset loaded successfully", LogLevel.Info);
                }
            }
            catch (Exception ex)
            {
                Monitor.Log($"=== EXCEPTION during asset injection for {e.Name} ===", LogLevel.Error);
                Monitor.Log($"Exception type: {ex.GetType().Name}", LogLevel.Error);
                Monitor.Log($"Exception message: {ex.Message}", LogLevel.Error);
                Monitor.Log($"Stack trace: {ex.StackTrace}", LogLevel.Error);
                Monitor.Log($"=== END EXCEPTION ===", LogLevel.Error);
            }
        }
    }
} 