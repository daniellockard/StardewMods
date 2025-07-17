# MapRegion

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string Id { get; }
- - public WorldMapRegionData Data { get; }
- - public MapRegion(string id, WorldMapRegionData data)
- - public Rectangle GetMapPixelBounds()
- - public MapAreaTexture GetBaseTexture()
- - public MapArea[] GetAreas()
- - public MapAreaPosition GetPositionData(GameLocation location, Point tile)

## Private Members
- - private Texture2D GetTexture(string assetName)

## Protected Members
- - protected Rectangle? CachedPixelBounds;
- - protected MapArea[] CachedMapAreas;
- - protected MapAreaTexture CachedBaseTexture;
- - protected string GetLocationName(GameLocation location)

## Internal Members
- - internal MapAreaPosition GetPositionData(GameLocation location, Point tile, LogBuilder log)

## Other Members
- *(None)*
