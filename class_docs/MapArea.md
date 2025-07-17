# MapArea

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string Id { get; }
- - public MapRegion Region { get; }
- - public WorldMapAreaData Data { get; }
- - public MapArea(MapRegion region, WorldMapAreaData data)
- - public MapAreaTexture[] GetTextures()
- - public MapAreaTooltip[] GetTooltips()
- - public IEnumerable<MapAreaPosition> GetWorldPositions()
- - public MapAreaPosition GetWorldPosition(string locationName, string contextName, Point tile)
- - public virtual string GetScrollText()

## Private Members
- - private Texture2D GetTexture(string assetName)

## Protected Members
- - protected MapAreaTexture[] CachedTextures;
- - protected MapAreaTooltip[] CachedTooltips;
- - protected MapAreaPosition[] CachedWorldPositions;
- - protected string CachedScrollText;

## Internal Members
- - internal MapAreaPosition GetWorldPosition(string locationName, string contextName, Point tile, LogBuilder log)

## Other Members
- *(None)*
