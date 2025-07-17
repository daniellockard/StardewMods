using StardewValley;
using System;
using System.Collections.Generic;

namespace GuineaPigMod
{
    public static class GuineaPigHelpers
    {
        public static string GetGenericName(string key)
        {
            // Handle guinea pig
            if (key.StartsWith("GuineaPigMod.GuineaPig"))
                return "GuineaPigMod.GuineaPig";
            
            // Handle vanilla animals like CustomFarmAnimals does
            switch (key)
            {
                case "Brown Cow":
                    return "Dairy Cow";
                case "White Cow":
                    return "Dairy Cow";
                case "Brown Chicken":
                    return "Chicken";
                case "White Chicken":
                    return "Chicken";
                case "Blue Chicken":
                    return "Chicken";
                case "Void Chicken":
                    return "Chicken";
                case "Golden Chicken":
                    return "Chicken";
                default:
                    return key;
            }
        }

        public static string GetTypeConditionalOnBuilding(string type)
        {
            switch (type)
            {
                case "Coop":
                    return (Game1.getFarm().isBuildingConstructed("Coop") || 
                           Game1.getFarm().isBuildingConstructed("Big Coop") || 
                           Game1.getFarm().isBuildingConstructed("Deluxe Coop")) 
                           ? null 
                           : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5926");
                case "Big Coop":
                    return (Game1.getFarm().isBuildingConstructed("Big Coop") || 
                           Game1.getFarm().isBuildingConstructed("Deluxe Coop")) 
                           ? null 
                           : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5940");
                case "Deluxe Coop":
                    return Game1.getFarm().isBuildingConstructed("Deluxe Coop") 
                           ? null 
                           : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5947");
                case "Barn":
                    return (Game1.getFarm().isBuildingConstructed("Barn") || 
                           Game1.getFarm().isBuildingConstructed("Big Barn") || 
                           Game1.getFarm().isBuildingConstructed("Deluxe Barn")) 
                           ? null 
                           : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5931");
                case "Big Barn":
                    return (Game1.getFarm().isBuildingConstructed("Big Barn") || 
                           Game1.getFarm().isBuildingConstructed("Deluxe Barn")) 
                           ? null 
                           : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5933");
                case "Deluxe Barn":
                    return Game1.getFarm().isBuildingConstructed("Deluxe Barn") 
                           ? null 
                           : Game1.content.LoadString("Strings\\StringsFromCSFiles:Utility.cs.5950");
                default:
                    return Game1.getFarm().isBuildingConstructed(type) 
                           ? null 
                           : $"You need a {type} to buy this animal.";
            }
        }

        public static string GetName(string key)
        {
            // For guinea pig, return the display name directly
            if (key == "GuineaPigMod.GuineaPig")
                return "Guinea Pig";
            
            // For other animals, try to get from FarmAnimals data like CustomFarmAnimals does
            try
            {
                var farmAnimalsData = Game1.content.Load<Dictionary<string, string>>("Data\\FarmAnimals");
                if (farmAnimalsData.TryGetValue(key, out string rawData))
                {
                    string[] split = rawData.Split('/');
                    if (split.Length > 25)
                        return split[25]; // Display name is at index 25
                }
            }
            catch (Exception)
            {
                // Fallback to key if data loading fails
            }
            
            return key;
        }
    }
} 