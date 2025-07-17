# MeleeWeapon

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int defenseCooldownTime = 1500;
- - public const int daggerCooldownTime = 3000;
- - public const int clubCooldownTime = 6000;
- - public const int millisecondsPerSpeedPoint = 40;
- - public const int defaultSpeed = 400;
- - public const int stabbingSword = 0;
- - public const int dagger = 1;
- - public const int club = 2;
- - public const int defenseSword = 3;
- - public const int baseClubSpeed = -8;
- - public const string scytheId = "47";
- - public const string goldenScytheId = "53";
- - public const string iridiumScytheID = "66";
- - public const string galaxySwordId = "4";
- - public const int MAX_FORGES = 3;
- - public readonly NetInt type = new NetInt();
- - public readonly NetInt minDamage = new NetInt();
- - public readonly NetInt maxDamage = new NetInt();
- - public readonly NetInt speed = new NetInt();
- - public readonly NetInt addedPrecision = new NetInt();
- - public readonly NetInt addedDefense = new NetInt();
- - public readonly NetInt addedAreaOfEffect = new NetInt();
- - public readonly NetFloat knockback = new NetFloat();
- - public readonly NetFloat critChance = new NetFloat();
- - public readonly NetFloat critMultiplier = new NetFloat();
- - public readonly NetString appearance = new NetString(null);
- - public bool isOnSpecial;
- - public static int defenseCooldown;
- - public static int attackSwordCooldown;
- - public static int daggerCooldown;
- - public static int clubCooldown;
- - public static int daggerHitsLeft;
- - public static int timedHitTimer;
- - public Rectangle mostRecentArea;
- - public override string TypeDefinitionId { get; } = "(W)";
- - public MeleeWeapon()
- - public MeleeWeapon(string itemId)
- - public WeaponData GetData()
- - public static bool TryGetData(string itemId, out WeaponData data)
- - public override bool CanBeLostOnDeath()
- - public override void AddEquipmentEffects(BuffEffects effects)
- - public override int GetMaxForges()
- - public override string getCategoryName()
- - public override string checkForSpecialItemHoldUpMeessage()
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override int maximumStackSize()
- - public override int salePrice(bool ignoreProfitMargins = false)
- - public static void weaponsTypeUpdate(GameTime time)
- - public override void tickUpdate(GameTime time, Farmer who)
- - public override bool doesShowTileLocationMarker()
- - public int getNumberOfDescriptionCategories()
- - public override void leftClick(Farmer who)
- - public override bool isScythe()
- - public static bool IsScythe(string id)
- - public virtual int getItemLevel()
- - public static Item attemptAddRandomInnateEnchantment(Item item, Random r, bool force = false, List<BaseEnchantment> enchantsToReroll = null)
- - public override string getDescription()
- - public virtual float defaultKnockBackForThisType(int type)
- - public virtual Rectangle getAreaOfEffect(int x, int y, int facingDirection, ref Vector2 tileLocation1, ref Vector2 tileLocation2, Rectangle wielderBoundingBox, int indexInCurrentAnimation)
- - public void triggerDefenseSwordFunction(Farmer who)
- - public void triggerDaggerFunction(Farmer who, int dagger_hits_left)
- - public void triggerClubFunction(Farmer who)
- - public virtual void animateSpecialMove(Farmer who)
- - public void doSwipe(int type, Vector2 position, int facingDirection, float swipeSpeed, Farmer f)
- - public virtual void FireProjectile(Farmer who)
- - public virtual void setFarmerAnimating(Farmer who)
- - public override void actionWhenStopBeingHeld(Farmer who)
- - public virtual void RecalculateAppliedForges(bool force = false)
- - public virtual void DoDamage(GameLocation location, int x, int y, int facingDirection, int power, Farmer who)
- - public string GetDrawnItemId()
- - public override void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
- - public override Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
- - public virtual void ResetIndexOfMenuItemView()
- - public virtual void drawDuringUse(int frameOfFarmerAnimation, int facingDirection, SpriteBatch spriteBatch, Vector2 playerPosition, Farmer f)
- - public override bool CanForge(Item item)
- - public override bool CanAddEnchantment(BaseEnchantment enchantment)
- - public bool isGalaxyWeapon()
- - public void transform(string newItemId)
- - public override bool Forge(Item item, bool count_towards_stats = false)
- - public static void drawDuringUse(int frameOfFarmerAnimation, int facingDirection, SpriteBatch spriteBatch, Vector2 playerPosition, Farmer f, string weaponItemId, int type, bool isOnSpecial)

## Private Members
- - private static float addedSwordScale = 0f;
- - private static float addedClubScale = 0f;
- - private static float addedDaggerScale = 0f;
- - private float swipeSpeed;
- - private readonly NetEvent0 animateSpecialMoveEvent = new NetEvent0();
- - private readonly NetEvent0 defenseSwordEvent = new NetEvent0();
- - private readonly NetEvent1Field<int, NetInt> daggerEvent = new NetEvent1Field<int, NetInt>();
- - private WeaponData cachedData;
- - private bool anotherClick;
- - private static Vector2 center = new Vector2(1f, 15f);
- - private void doDefenseSwordFunction()
- - private void doDaggerFunction(int dagger_hits)
- - private void beginSpecialMove(Farmer who)
- - private void quickStab(Farmer who)

## Protected Members
- - protected void ReloadData()
- - protected override void MigrateLegacyItemId()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)
- - protected override string loadDisplayName()
- - protected override string loadDescription()
- - protected override void initNetFields()
- - protected virtual int specialCooldown()
- - protected virtual void doAnimateSpecialMove()

## Internal Members
- *(None)*

## Other Members
- *(None)*
