# GiantCrop

**Summary:** Represents a crop that can be grown on the farm.

## Public Members
- - public readonly NetString netId = new NetString();
- - public string Id
- - public GiantCrop()
- - public GiantCrop(string id, Vector2 tile)
- - public override void initNetFields()
- - public override void draw(SpriteBatch spriteBatch)
- - public override bool performToolAction(Tool t, int damage, Vector2 tileLocation)
- - public GiantCropData GetData()
- - public static bool TryGetData(string id, out GiantCropData data)
- - public static IReadOnlyList<KeyValuePair<string, GiantCropData>> GetGiantCropsFor(string cropId)
- - public static bool RebuildCropIdCacheIfNeeded(bool forceRebuild = false)
- - public Item TryGetDrop(GiantCropHarvestItemData drop, Random r, Farmer targetFarmer, bool isShaving, float healthDeducted)

## Private Members
- - private static readonly Dictionary<string, List<KeyValuePair<string, GiantCropData>>> CacheByCropId = new Dictionary<string, List<KeyValuePair<string, GiantCropData>>>();
- - private static int CacheTick;
- - private void AdjustStackSizeWhenShaving(Item item, int? min, int? max, float healthDeducted, Random random)
- - private string GetIdFromLegacySpriteIndex(int spriteIndex)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
