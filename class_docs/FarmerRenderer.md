# FarmerRenderer

**Summary:** Represents the player character, including stats, inventory, and actions.

## Public Members
- - public enum FarmerSpriteLayers
- - public const int sleeveDarkestColorIndex = 256;
- - public const int skinDarkestColorIndex = 260;
- - public const int shoeDarkestColorIndex = 268;
- - public const int eyeLightestColorIndex = 276;
- - public const int accessoryDrawBelowHairThreshold = 8;
- - public const int accessoryFacialHairThreshold = 6;
- - public static bool isDrawingForUI = false;
- - public const int TransparentSkin = -12345;
- - public const int pantsOffset = 288;
- - public const int armOffset = 96;
- - public const int shirtXOffset = 16;
- - public const int shirtYOffset = 56;
- - public static int[] featureYOffsetPerFrame = new int[126]
- - public static int[] featureXOffsetPerFrame = new int[126]
- - public static int[] hairstyleHatOffset = new int[16]
- - public static Texture2D hairStylesTexture;
- - public static Texture2D shirtsTexture;
- - public static Texture2D hatsTexture;
- - public static Texture2D accessoriesTexture;
- - public static Texture2D pantsTexture;
- - public static Dictionary<string, Dictionary<int, List<int>>> recolorOffsets;
- - public readonly NetString textureName = new NetString();
- - public readonly NetInt heightOffset = new NetInt(0);
- - public readonly NetColor eyes = new NetColor();
- - public readonly NetInt skin = new NetInt();
- - public readonly NetString shoes = new NetString();
- - public readonly NetString shirt = new NetString();
- - public readonly NetString pants = new NetString();
- - public Rectangle shirtSourceRect;
- - public Rectangle hairstyleSourceRect;
- - public Rectangle hatSourceRect;
- - public Rectangle accessorySourceRect;
- - public Vector2 rotationAdjustment;
- - public Vector2 positionOffset;
- - public NetFields NetFields { get; } = new NetFields("FarmerRenderer");
- - public FarmerRenderer()
- - public FarmerRenderer(string textureName, Farmer farmer)
- - public bool isAccessoryFacialHair(int which)
- - public bool drawAccessoryBelowHair(int which)
- - public void unload()
- - public void textureChanged()
- - public void recolorEyes(Color lightestColor)
- - public void ApplyEyeColor(string texture_name, Color[] pixels)
- - public void recolorShoes(string which)
- - public int recolorSkin(int which, bool force = false)
- - public void changeShirt(string whichShirt)
- - public void changePants(string whichPants)
- - public void MarkSpriteDirty()
- - public void ApplySleeveColor(string texture_name, Color[] pixels, Farmer who)
- - public static Color changeBrightness(Color c, int brightness)
- - public void draw(SpriteBatch b, Farmer who, int whichFrame, Vector2 position, float layerDepth = 1f, bool flip = false)
- - public void draw(SpriteBatch b, FarmerSprite farmerSprite, Rectangle sourceRect, Vector2 position, Vector2 origin, float layerDepth, Color overrideColor, float rotation, Farmer who)
- - public void drawMiniPortrat(SpriteBatch b, Vector2 position, float layerDepth, float scale, int facingDirection, Farmer who, float alpha = 1f)
- - public void draw(SpriteBatch b, FarmerSprite.AnimationFrame animationFrame, int currentFrame, Rectangle sourceRect, Vector2 position, Vector2 origin, float layerDepth, Color overrideColor, float rotation, float scale, Farmer who)
- - public void drawHairAndAccesories(SpriteBatch b, int facingDirection, Farmer who, Vector2 position, Vector2 origin, float scale, int currentFrame, float rotation, Color overrideColor, float layerDepth)
- - public static float GetLayerDepth(float baseLayerDepth, FarmerSpriteLayers layer, bool dyeLayer = false)
- - public void draw(SpriteBatch b, FarmerSprite.AnimationFrame animationFrame, int currentFrame, Rectangle sourceRect, Vector2 position, Vector2 origin, float layerDepth, int facingDirection, Color overrideColor, float rotation, float scale, Farmer who)

## Private Members
- - private LocalizedContentManager farmerTextureManager;
- - private void executeRecolorActions(Farmer farmer)
- - private void _SwapColor(string texture_name, Color[] pixels, int color_index, Color color)
- - private void ApplyShoeColor(string texture_name, Color[] pixels)
- - private void ApplySkinColor(string texture_name, Color[] pixels)

## Protected Members
- - protected bool _sickFrame;
- - protected bool _spriteDirty;
- - protected bool _baseTextureDirty;
- - protected bool _eyesDirty;
- - protected bool _skinDirty;
- - protected bool _shoesDirty;
- - protected bool _shirtDirty;
- - protected bool _pantsDirty;
- - protected void _GeneratePixelIndices(int source_color_index, string texture_name, Color[] pixels)

## Internal Members
- - internal Texture2D baseTexture;

## Other Members
- *(None)*
