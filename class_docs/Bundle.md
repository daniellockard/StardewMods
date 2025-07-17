# Bundle

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int NameIndex = 0;
- - public const int RewardIndex = 1;
- - public const int IngredientsIndex = 2;
- - public const int ColorIndex = 3;
- - public const int NumberOfSlotsIndex = 4;
- - public const int SpriteIndex = 5;
- - public const int DisplayNameIndex = 6;
- - public const int FieldCount = 7;
- - public const float shakeRate = (float)Math.PI / 200f;
- - public const float shakeDecayRate = 0.0030679617f;
- - public const int Color_Green = 0;
- - public const int Color_Purple = 1;
- - public const int Color_Orange = 2;
- - public const int Color_Yellow = 3;
- - public const int Color_Red = 4;
- - public const int Color_Blue = 5;
- - public const int Color_Teal = 6;
- - public const float DefaultShakeForce = (float)Math.PI * 3f / 128f;
- - public string rewardDescription;
- - public List<BundleIngredientDescription> ingredients;
- - public int bundleColor;
- - public int numberOfIngredientSlots;
- - public int bundleIndex;
- - public int completionTimer;
- - public bool complete;
- - public bool depositsAllowed = true;
- - public Texture2D bundleTextureOverride;
- - public int bundleTextureIndexOverride = -1;
- - public TemporaryAnimatedSprite sprite;
- - public Bundle(string name, string displayName, List<BundleIngredientDescription> ingredients, bool[] completedIngredientsList, string rewardListString = "")
- - public Bundle(int bundleIndex, string rawBundleInfo, bool[] completedIngredientsList, Point position, string textureName, JunimoNoteMenu menu)
- - public Item getReward()
- - public void shake(float force = (float)Math.PI * 3f / 128f)
- - public void shake(int extraInfo)
- - public void tryHoverAction(int x, int y)
- - public bool IsValidItemForThisIngredientDescription(Item item, BundleIngredientDescription ingredient)
- - public int GetBundleIngredientDescriptionIndexForItem(Item item)
- - public bool canAcceptThisItem(Item item, ClickableTextureComponent slot)
- - public bool canAcceptThisItem(Item item, ClickableTextureComponent slot, bool ignore_stack_count = false)
- - public Item tryToDepositThisItem(Item item, ClickableTextureComponent slot, string noteTextureName, JunimoNoteMenu parentMenu)
- - public void ingredientDepositAnimation(ClickableTextureComponent slot, string noteTextureName, bool skipAnimation = false)
- - public bool canBeClicked()
- - public void completionAnimation(JunimoNoteMenu menu, bool playSound = true, int delay = 0)
- - public void update(GameTime time)
- - public void draw(SpriteBatch b)
- - public static Color getColorFromColorIndex(int color)
- - public struct BundleIngredientDescription
- - public readonly string id;
- - public string preservesId;
- - public readonly int? category;
- - public readonly int stack;
- - public readonly int quality;
- - public bool completed;
- - public BundleIngredientDescription(string idOrCategory, int stack, int quality, bool completed, string preservesId = null)
- - public BundleIngredientDescription(BundleIngredientDescription other, bool completed)

## Private Members
- - private float maxShake;
- - private bool shakeLeft;
- - private void completionAnimation(bool playSound = true)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
