# MapAreaPosition

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public MapRegion Region { get; }
- - public MapArea Area { get; }
- - public WorldMapAreaPositionData Data { get; }
- - public MapAreaPosition(MapArea mapArea, WorldMapAreaPositionData data)
- - public bool Matches(string locationName, string contextName, Point tile)
- - public Rectangle GetPixelArea()
- - public Vector2 GetMapPixelPosition(GameLocation location, Point tileLocation)
- - public string GetScrollText(Point playerTile)
- - public virtual Vector2? GetPositionRatioIfValid(GameLocation location, Point tile)
- - public virtual bool IsTileWithinZone(Point tile)
- - public readonly struct MapAreaPositionWithContext
- - public MapAreaPosition Data { get; }
- - public GameLocation Location { get; }
- - public Point Tile { get; }
- - public MapAreaPositionWithContext(MapAreaPosition data, GameLocation location, Point tile)
- - public Vector2 GetMapPixelPosition()
- - public Vector2? GetPositionRatioIfValid()
- - public string GetScrollText()

## Private Members
- *(None)*

## Protected Members
- - protected Rectangle? CachedMapPixelArea;
- - protected string CachedScrollText;
- - protected bool IsFixedMapPosition;

## Internal Members
- - internal bool Matches(string locationName, string contextName, Point tile, LogBuilder log)

## Other Members
- *(None)*
