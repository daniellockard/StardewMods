# WorldMapManager

**Summary:** Handles or manages a specific system or feature.

## Public Members
- - public static void ReloadData()
- - public static IEnumerable<MapRegion> GetMapRegions()
- - public static MapAreaPositionWithContext? GetPositionData(GameLocation location, Point tile)
- - public static MapAreaPosition GetPositionDataWithoutFallback(GameLocation location, Point tile)

## Private Members
- - private static int NextClearCacheTick;
- - private static int MaxCacheTicks;
- - private static readonly List<MapRegion> Regions;
- - private static void ReloadDataIfStale()

## Protected Members
- *(None)*

## Internal Members
- - internal static MapAreaPositionWithContext? GetPositionData(GameLocation location, Point tile, LogBuilder log)
- - internal static MapAreaPosition GetPositionDataWithoutFallback(GameLocation location, Point tile, LogBuilder log)

## Other Members
- - static WorldMapManager()
