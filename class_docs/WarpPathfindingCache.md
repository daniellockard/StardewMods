# WarpPathfindingCache

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static readonly HashSet<string> IgnoreLocationNames = new HashSet<string> { "Backwoods", "Cellar", "Farm" };
- - public static readonly Dictionary<string, string> OverrideTargetNames = new Dictionary<string, string> { ["BoatTunnel"] = "IslandSouth" };
- - public static readonly Dictionary<string, Gender> GenderRestrictions = new Dictionary<string, Gender>
- - public static void PopulateCache()
- - public static string[] GetLocationRoute(string startingLocation, string endingLocation, Gender gender)

## Private Members
- - private static readonly Dictionary<string, List<LocationWarpRoute>> Routes = new Dictionary<string, List<LocationWarpRoute>>();
- - private static void ExploreWarpPoints(GameLocation location, List<string> route, Gender? genderRestriction)
- - private static void ExploreWarpPoints(string locationName, List<string> route, Gender? genderRestriction, HashSet<string> seenTargets)
- - private static void AddRoute(List<string> route, Gender? onlyGender)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
