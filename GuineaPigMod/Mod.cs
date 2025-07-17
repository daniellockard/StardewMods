using StardewModdingAPI;
using StardewModdingAPI.Events;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using StardewValley.GameData.FarmAnimals;
using StardewValley.GameData;
using HarmonyLib;
using StardewValley;
using Microsoft.Xna.Framework;

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
            // Set up asset injection
            helper.Events.Content.AssetRequested += OnAssetRequested;
            // Set up stuck animal handling
            helper.Events.GameLoop.SaveLoaded += OnSaveLoaded;
            helper.Events.World.LocationListChanged += OnLocationListChanged;
            Monitor.Log("AssetRequested event handler registered successfully", LogLevel.Info);
            Monitor.Log("=== GUINEA PIG MOD STARTUP COMPLETE ===", LogLevel.Info);
        }
        
        /// <summary>
        /// Handle asset requests for our custom objects
        /// </summary>
        private void OnAssetRequested(object sender, AssetRequestedEventArgs e)
        {
            // Only log debug info for our guinea pig assets
            bool isGuineaPigAsset = e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/texture_1.png") ||
                                   e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/gpicon.png") ||
                                   e.NameWithoutLocale.IsEquivalentTo("Mods/GuineaPigMod/assets/poop_pile.png");
            
            if (isGuineaPigAsset)
            {
                Monitor.Log($"=== GUINEA PIG ASSET REQUESTED: {e.Name} ===", LogLevel.Info);
                Monitor.Log($"Asset type: {e.Name.GetType().Name}", LogLevel.Info);
                Monitor.Log($"Asset name without locale: {e.NameWithoutLocale}", LogLevel.Info);
            }
            
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
                // Inject guinea pig animal with custom texture and shop icon into Data/FarmAnimals
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
                            SpriteHeight = 32,
                            UseFlippedRightForLeft = false,
                            UseDoubleUniqueAnimationFrames = true,
                            Gender = FarmAnimalGender.Female,
                            // Set hitbox size for 32x32 sprites to 1x1 for smoother pathfinding
                            UpDownPetHitboxTileSize = new Microsoft.Xna.Framework.Vector2(1, 1),
                            LeftRightPetHitboxTileSize = new Microsoft.Xna.Framework.Vector2(1, 1),
                            BabyUpDownPetHitboxTileSize = new Microsoft.Xna.Framework.Vector2(1, 1),
                            BabyLeftRightPetHitboxTileSize = new Microsoft.Xna.Framework.Vector2(1, 1)
                        };
                        
                        var entryKey = "GuineaPigMod.GuineaPig";
                        data[entryKey] = guineaPigEntry;
                        Monitor.Log($"Injected guinea pig with custom texture and shop icon into Data/FarmAnimals.", LogLevel.Info);
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
                            ["ShopIcon"] = "Mods/GuineaPigMod/assets/gpicon.png",
                            // New: Use ProduceItemIds for 7-8 poops per day
                            ["ProduceItemIds"] = new List<object>
                            {
                                new Dictionary<string, object>
                                {
                                    ["ItemId"] = AssetInjector.PoopPileId.ToString(),
                                    ["MinAmount"] = 7,
                                    ["MaxAmount"] = 8
                                }
                            },
                            ["DaysToProduce"] = 1,
                            ["ProduceOnMature"] = true,
                            // Note: Babies cannot produce via data model alone; only adults will produce poop.
                            ["HarvestType"] = "DigUp",
                            ["Home"] = "Coop",
                            ["CanBePurchased"] = true
                        };
                        
                        var entryKey = "GuineaPigMod.GuineaPig";
                        data[entryKey] = guineaPigEntry;
                        Monitor.Log($"Injected guinea pig with custom texture and shop icon into Data/Animals.", LogLevel.Info);
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
                
                // Add crafting recipes for fertilizer
                if (e.Name.IsEquivalentTo("Data/CraftingRecipes"))
                {
                    Monitor.Log("Processing Data/CraftingRecipes asset...", LogLevel.Info);
                    e.Edit(asset =>
                    {
                        Monitor.Log("Editing Data/CraftingRecipes asset...", LogLevel.Info);
                        var data = asset.AsDictionary<string, string>().Data;
                        Monitor.Log($"Current CraftingRecipes entries count: {data.Count}", LogLevel.Info);
                        
                        // Basic Fertilizer: 1 Poop Pile + 1 Sap = 3 Basic Fertilizer (Agriculture level 1)
                        var basicFertilizerRecipe = $"Basic Fertilizer/3 1 {AssetInjector.PoopPileId} 1 92/1/false/Agriculture";
                        data["Basic Fertilizer (Guinea Pig)"] = basicFertilizerRecipe;
                        
                        // Quality Fertilizer: 2 Poop Piles + 1 Sap = 2 Quality Fertilizer (Agriculture level 3)
                        var qualityFertilizerRecipe = $"Quality Fertilizer/2 2 {AssetInjector.PoopPileId} 1 92/3/false/Agriculture";
                        data["Quality Fertilizer (Guinea Pig)"] = qualityFertilizerRecipe;
                        
                        // Deluxe Fertilizer: 3 Poop Piles + 1 Sap = 1 Deluxe Fertilizer (Agriculture level 6)
                        var deluxeFertilizerRecipe = $"Deluxe Fertilizer/1 3 {AssetInjector.PoopPileId} 1 92/6/false/Agriculture";
                        data["Deluxe Fertilizer (Guinea Pig)"] = deluxeFertilizerRecipe;
                        
                        Monitor.Log($"Injected crafting recipes for fertilizer using guinea pig poop.", LogLevel.Info);
                        Monitor.Log($"Basic Fertilizer recipe: {basicFertilizerRecipe}", LogLevel.Info);
                        Monitor.Log($"Quality Fertilizer recipe: {qualityFertilizerRecipe}", LogLevel.Info);
                        Monitor.Log($"Deluxe Fertilizer recipe: {deluxeFertilizerRecipe}", LogLevel.Info);
                        Monitor.Log($"CraftingRecipes entries count after injection: {data.Count}", LogLevel.Info);
                    });
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

        static void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            if (!Context.IsMainPlayer) return;
            Utility.ForEachLocation((GameLocation location) =>
            {
                location.animals.OnValueAdded += (long id, FarmAnimal animal) =>
                {
                    DelayedAction.functionAfterDelay(() => HandleStuckAnimals(animal, location), 10);
                };
                return true;
            });
        }

        static void OnLocationListChanged(object sender, LocationListChangedEventArgs e)
        {
            if (!Context.IsMainPlayer) return;
            foreach (var location in e.Added)
            {
                location.animals.OnValueAdded += (long id, FarmAnimal animal) =>
                {
                    DelayedAction.functionAfterDelay(() => HandleStuckAnimals(animal, location), 10);
                };
            }
        }

        static void HandleStuckAnimals(FarmAnimal animal, GameLocation location)
        {
            if (animal.type.Value != "GuineaPigMod.GuineaPig") return;

            // Helper: teleport inside
            void TeleportInside()
            {
                Instance.Monitor.Log($"Teleporting {animal.type.Value} inside to prevent getting stuck.", LogLevel.Info);
                animal.currentLocation = animal.home.indoors.Value;
                animal.Position = animal.home.indoors.Value.getRandomTile().ToVector2() * 64f;
                animal.setRandomPosition(animal.home.indoors.Value);
                animal.controller = null;
                animal.faceDirection(2); // face down
                animal.forceUpdateTimer = 0;
                animal.reload();
            }

            // If after 5pm and guinea pig is near the coop door, teleport inside
            if (Game1.timeOfDay >= 1700 && animal.home != null && animal.currentLocation != animal.home.indoors.Value)
            {
                var doorRect = animal.home.getRectForAnimalDoor();
                var animalBox = animal.GetBoundingBox();
                // Consider 'near' if within 2 tiles (64 pixels) of the door
                Rectangle expandedDoor = new Rectangle(doorRect.X - 64, doorRect.Y - 64, doorRect.Width + 128, doorRect.Height + 128);
                if (expandedDoor.Intersects(animalBox))
                {
                    TeleportInside();
                    return;
                }
            }

            // Existing logic for door squeeze (optional, can keep for extra safety)
            if (animal.home is not null &&
                (animal.GetAnimalData()?.SpriteWidth ?? 16) / 16 > (animal.home.GetData()?.AnimalDoor.Width ?? 1) &&
                location.buildings.Contains(animal.home) &&
                animal.home.intersects(animal.GetBoundingBox()))
            {
                Instance.Monitor.Log($"Squeezing the big {animal.type.Value} through the {animal.home.buildingType.Value}'s teeny door", LogLevel.Info);
                var rectForAnimalDoor = animal.home.getRectForAnimalDoor();
                animal.Position = new Vector2(rectForAnimalDoor.X - 64, rectForAnimalDoor.Y);
                return;
            }
        }
    }
} 