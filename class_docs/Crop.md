# Crop

**Summary:** Represents a crop that can be grown on the farm.

## Public Members
- - public const string mixedSeedsId = "770";
- - public const string mixedSeedsQId = "(O)770";
- - public const int seedPhase = 0;
- - public const int rowOfWildSeeds = 23;
- - public const int finalPhaseLength = 99999;
- - public const int forageCrop_springOnion = 1;
- - public const string forageCrop_springOnionID = "1";
- - public const int forageCrop_ginger = 2;
- - public const string forageCrop_gingerID = "2";
- - public const int specialVariable_farmedForageCrop = 724519;
- - public readonly NetIntList phaseDays = new NetIntList();
- - public readonly NetInt rowInSpriteSheet = new NetInt();
- - public readonly NetInt phaseToShow = new NetInt(-1);
- - public readonly NetInt currentPhase = new NetInt();
- - public readonly NetString indexOfHarvest = new NetString();
- - public readonly NetInt dayOfCurrentPhase = new NetInt();
- - public readonly NetString whichForageCrop = new NetString();
- - public readonly NetString replaceWithObjectOnFullGrown = new NetString();
- - public readonly NetColor tintColor = new NetColor();
- - public readonly NetBool flip = new NetBool();
- - public readonly NetBool fullyGrown = new NetBool();
- - public readonly NetBool raisedSeeds = new NetBool();
- - public readonly NetBool programColored = new NetBool();
- - public readonly NetBool dead = new NetBool();
- - public readonly NetBool forageCrop = new NetBool();
- - public readonly NetString netSeedIndex = new NetString();
- - public readonly NetString overrideTexturePath = new NetString();
- - public Vector2 drawPosition;
- - public Vector2 tilePosition;
- - public float layerDepth;
- - public float coloredLayerDepth;
- - public Rectangle sourceRect;
- - public Rectangle coloredSourceRect;
- - public GameLocation currentLocation
- - public HoeDirt Dirt { get; set; }
- - public Texture2D DrawnCropTexture
- - public ModDataDictionary modData { get; } = new ModDataDictionary();
- - public ModDataDictionary modDataForSerialization
- - public NetFields NetFields { get; } = new NetFields("Crop");
- - public Crop()
- - public Crop(bool forageCrop, string which, int tileX, int tileY, GameLocation location)
- - public Crop(string seedId, int tileX, int tileY, GameLocation location)
- - public static string ResolveSeedId(string itemId, GameLocation location)
- - public CropData GetData()
- - public static bool TryGetData(string seedId, out CropData data)
- - public bool IsInSeason(GameLocation location)
- - public static bool IsInSeason(GameLocation location, string seedId)
- - public HarvestMethod GetHarvestMethod()
- - public bool RegrowsAfterHarvest()
- - public virtual bool IsErrorCrop()
- - public virtual void ResetPhaseDays()
- - public static string getRandomLowGradeCropForThisSeason(Season season)
- - public static string getRandomFlowerSeedForThisSeason(Season season)
- - public virtual void growCompletely()
- - public virtual bool hitWithHoe(int xTile, int yTile, GameLocation location, HoeDirt dirt)
- - public virtual bool harvest(int xTile, int yTile, HoeDirt soil, JunimoHarvester junimoHarvester = null, bool isForcedScytheHarvest = false)
- - public string getRandomWildCropForSeason(bool onlyDeterministic = false)
- - public string getRandomWildCropForSeason(Season season)
- - public virtual Rectangle getSourceRect(int number)
- - public bool TryGetGiantCrops(out IReadOnlyList<KeyValuePair<string, GiantCropData>> giantCrops)
- - public void Kill()
- - public virtual void newDay(int state)
- - public virtual bool TryGrowGiantCrop(bool checkPreconditions = true, Random random = null)
- - public virtual bool isPaddyCrop()
- - public virtual bool shouldDrawDarkWhenWatered()
- - public virtual bool isWildSeedCrop()
- - public virtual void updateDrawMath(Vector2 tileLocation)
- - public virtual void draw(SpriteBatch b, Vector2 tileLocation, Color toTint, float rotation)
- - public virtual void drawInMenu(SpriteBatch b, Vector2 screenPosition, Color toTint, float rotation, float scale, float layerDepth)
- - public virtual void drawWithOffset(SpriteBatch b, Vector2 tileLocation, Color toTint, float rotation, Vector2 offset)
- - public interface ICue : IDisposable

## Private Members
- - private GameLocation currentLocationImpl;
- - private static Vector2 origin = new Vector2(8f, 24f);
- - private static Vector2 smallestTileSizeOrigin = new Vector2(8f, 8f);

## Protected Members
- - protected Texture2D _drawnTexture;
- - protected bool? _isErrorCrop;

## Internal Members
- *(None)*

## Other Members
- *(None)*
