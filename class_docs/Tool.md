# Tool

**Summary:** Represents a tool used by the player (hoe, axe, etc.).

## Public Members
- - public const int standardStaminaReduction = 2;
- - public const int stone = 0;
- - public const int copper = 1;
- - public const int steel = 2;
- - public const int gold = 3;
- - public const int iridium = 4;
- - public const int hammerSpriteIndex = 105;
- - public const int wateringCanSpriteIndex = 273;
- - public const int fishingRodSpriteIndex = 8;
- - public const int wateringCanMenuIndex = 296;
- - public const string weaponsTextureName = "TileSheets\\weapons";
- - public static Texture2D weaponsTexture;
- - public readonly NetInt initialParentTileIndex = new NetInt();
- - public readonly NetInt currentParentTileIndex = new NetInt();
- - public readonly NetInt indexOfMenuItemView = new NetInt();
- - public readonly NetBool instantUse = new NetBool();
- - public readonly NetBool isEfficient = new NetBool();
- - public readonly NetFloat animationSpeedModifier = new NetFloat(1f);
- - public int swingTicker = Game1.random.Next(999999);
- - public readonly NetInt upgradeLevel = new NetInt();
- - public readonly NetInt numAttachmentSlots = new NetInt();
- - public Farmer lastUser;
- - public readonly NetObjectArray<Object> attachments = new NetObjectArray<Object>();
- - public readonly NetList<BaseEnchantment, NetRef<BaseEnchantment>> enchantments = new NetList<BaseEnchantment, NetRef<BaseEnchantment>>();
- - public readonly NetStringList previousEnchantments = new NetStringList();
- - public bool PlayUseSounds = true;
- - public string description
- - public override string TypeDefinitionId { get; } = "(T)";
- - public override string DisplayName => loadDisplayName();
- - public string Description => description;
- - public int CurrentParentTileIndex
- - public int InitialParentTileIndex
- - public int IndexOfMenuItemView
- - public int UpgradeLevel
- - public int AttachmentSlotsCount
- - public bool InstantUse
- - public bool IsEfficient
- - public float AnimationSpeedModifier
- - public Tool()
- - public Tool(string name, int upgradeLevel, int initialParentTileIndex, int indexOfMenuItemView, bool stackable, int numAttachmentSlots = 0)
- - public virtual void SetSpriteIndex(int spriteIndex)
- - public override bool CanBeLostOnDeath()
- - public override string getCategoryName()
- - public virtual void UpgradeFrom(Tool other)
- - public override Color getCategoryColor()
- - public ToolData GetToolData()
- - public virtual void draw(SpriteBatch b)
- - public override void drawAttachments(SpriteBatch b, int x, int y)
- - public override void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
- - public override Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
- - public virtual void tickUpdate(GameTime time, Farmer who)
- - public virtual bool isHeavyHitter()
- - public virtual bool isScythe()
- - public virtual void Update(int direction, int farmerMotionFrame, Farmer who)
- - public override int salePrice(bool ignoreProfitMargins = false)
- - public override int attachmentSlots()
- - public Farmer getLastFarmerToUse()
- - public virtual void leftClick(Farmer who)
- - public virtual void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
- - public virtual void endUsing(GameLocation location, Farmer who)
- - public virtual bool beginUsing(GameLocation location, int x, int y, Farmer who)
- - public virtual bool onRelease(GameLocation location, int x, int y, Farmer who)
- - public override bool canBeDropped()
- - public virtual bool canThisBeAttached(Object o)
- - public virtual Object attach(Object o)
- - public virtual void actionWhenClaimed()
- - public override bool CanBuyItem(Farmer who)
- - public override bool actionWhenPurchased(string shopId)
- - public virtual bool doesShowTileLocationMarker()
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override bool isPlaceable()
- - public override int maximumStackSize()
- - public override string getDescription()
- - public virtual void ClearEnchantments()
- - public virtual int GetMaxForges()
- - public virtual bool CanAddEnchantment(BaseEnchantment enchantment)
- - public virtual void CopyEnchantments(Tool source, Tool destination)
- - public int GetTotalForgeLevels(bool for_unforge = false)
- - public virtual bool AddEnchantment(BaseEnchantment enchantment)
- - public bool hasEnchantmentOfType<T>()
- - public virtual void RemoveEnchantment(BaseEnchantment enchantment)
- - public override void actionWhenBeingHeld(Farmer who)
- - public override void actionWhenStopBeingHeld(Farmer who)
- - public virtual bool CanUseOnStandingTile()
- - public override void AddEquipmentEffects(BuffEffects effects)
- - public virtual bool CanForge(Item item)
- - public T GetEnchantmentOfType<T>() where T : BaseEnchantment
- - public int GetEnchantmentLevel<T>() where T : BaseEnchantment
- - public virtual bool Forge(Item item, bool count_towards_stats = false)

## Private Members
- - private string _description;

## Protected Members
- - protected string displayName;
- - protected new virtual void initNetFields()
- - protected override void MigrateLegacyItemId()
- - protected virtual string loadDisplayName()
- - protected virtual string loadDescription()
- - protected override void GetOneCopyFrom(Item source)
- - protected virtual void DrawAttachmentSlot(int slot, SpriteBatch b, int x, int y)
- - protected virtual void GetAttachmentSlotSprite(int slot, out Texture2D texture, out Rectangle sourceRect)
- - protected virtual bool canThisBeAttached(Object o, int slot)
- - protected List<Vector2> tilesAffected(Vector2 tileLocation, int power, Farmer who)
- - protected override int getDescriptionWidth()

## Internal Members
- *(None)*

## Other Members
- *(None)*
