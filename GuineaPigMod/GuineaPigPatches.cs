using HarmonyLib;
using StardewValley;
using StardewValley.Menus;
using StardewValley.Characters;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using Object = StardewValley.Object;

namespace GuineaPigMod
{
    [HarmonyPatch]
    public static class GuineaPigPatches
    {
        // Patch stubs will go here
    }

    // Patch the PurchaseAnimalsMenu constructor to add the guinea pig to the shop
    [HarmonyPatch(typeof(PurchaseAnimalsMenu), MethodType.Constructor, new Type[] { typeof(List<Object>), typeof(GameLocation) })]
    public class PurchaseAnimalsMenu_Constructor_Patch
    {
        public static void Postfix(PurchaseAnimalsMenu __instance, List<Object> stock, GameLocation targetLocation)
        {
            var mod = Mod.Instance;
            if (mod?.Config?.EnableMod != true)
                return;
            string guineaPigKey = "GuineaPigMod.GuineaPig";
            // Only add if not already present
            if (!stock.Exists(a => a.Name == guineaPigKey))
            {
                var guineaPig = new Object("100", 1, false, 2000, 0)
                {
                    Name = guineaPigKey,
                    Type = "Coop",
                    displayName = "Guinea Pig"
                };
                int i = stock.Count;
                __instance.animalsToPurchase.Add(new ClickableTextureComponent(
                    guineaPig.salePrice().ToString() ?? "",
                    new Microsoft.Xna.Framework.Rectangle(
                        __instance.xPositionOnScreen + StardewValley.Menus.IClickableMenu.borderWidth + i % 3 * 64 * 2,
                        __instance.yPositionOnScreen + StardewValley.Menus.IClickableMenu.spaceToClearTopBorder + StardewValley.Menus.IClickableMenu.borderWidth / 2 + i / 3 * 85,
                        128, 64),
                    null,
                    guineaPig.Name,
                    Game1.content.Load<Microsoft.Xna.Framework.Graphics.Texture2D>("Mods/GuineaPigMod/assets/gpicon.png"),
                    new Microsoft.Xna.Framework.Rectangle(0, 0, 32, 16),
                    4f)
                {
                    item = guineaPig,
                    myID = i,
                    rightNeighborID = ((i % 3 == 2) ? -1 : (i + 1)),
                    leftNeighborID = ((i % 3 == 0) ? -1 : (i - 1)),
                    downNeighborID = i + 3,
                    upNeighborID = i - 3
                });
            }
        }
    }

    // Patch FarmAnimal constructor to ensure correct type/data for guinea pig
    [HarmonyPatch(typeof(FarmAnimal), MethodType.Constructor, new[] { typeof(string), typeof(long), typeof(long) })]
    public class FarmAnimal_Constructor_Patch
    {
        public static void Prefix(FarmAnimal __instance, string type, ref string __state)
        {
            var mod = Mod.Instance;
            if (mod?.Config?.EnableMod != true)
                return;
            __state = type;
        }
        public static void Postfix(FarmAnimal __instance, string type, string __state)
        {
            var mod = Mod.Instance;
            if (mod?.Config?.EnableMod != true || __state == type || type != "GuineaPigMod.GuineaPig")
                return;
            __instance.type.Value = __state;
            __instance.ReloadTextureIfNeeded(true);
        }
    }

    // Patch FarmAnimal update to fix collision issues for guinea pigs
    [HarmonyPatch(typeof(FarmAnimal), "updateWhenCurrentLocation")]
    public class FarmAnimal_Update_Patch
    {
        public static void Postfix(FarmAnimal __instance, GameTime time)
        {
            var mod = Mod.Instance;
            if (mod?.Config?.EnableMod != true || __instance.type.Value != "GuineaPigMod.GuineaPig")
                return;

            // Handle stuck guinea pigs using logic from AnimalSqueezeThrough mod
            HandleStuckGuineaPigs(__instance, __instance.currentLocation);
        }

        private static void HandleStuckGuineaPigs(FarmAnimal animal, GameLocation location)
        {
            if (animal.home is not null &&
                (animal.GetAnimalData()?.SpriteWidth ?? 16) / 16 > (animal.home.GetData()?.AnimalDoor.Width ?? 1) &&
                location.buildings.Contains(animal.home) &&
                animal.home.intersects(animal.GetBoundingBox()))
            {
                Mod.Instance.Monitor.Log($"Squeezing the big {animal.type.Value} through the {animal.home.buildingType.Value}'s teeny door", LogLevel.Info);
                var rectForAnimalDoor = animal.home.getRectForAnimalDoor();
                animal.Position = new Vector2(rectForAnimalDoor.X - 64, rectForAnimalDoor.Y);
                return;
            }
        }
    }
} 