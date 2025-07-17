# Ring

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const string SmallGlowRingId = "516";
- - public const string GlowRingId = "517";
- - public const string SmallMagnetRingId = "518";
- - public const string MagnetRingId = "519";
- - public const string SlimeCharmerRingId = "520";
- - public const string WarriorRingId = "521";
- - public const string VampireRingId = "522";
- - public const string SavageRingId = "523";
- - public const string YobaRingId = "524";
- - public const string SturdyRingId = "525";
- - public const string BurglarsRingId = "526";
- - public const string IridiumBandId = "527";
- - public const string AmethystRingId = "529";
- - public const string TopazRingId = "530";
- - public const string AquamarineRingId = "531";
- - public const string JadeRingId = "532";
- - public const string EmeraldRingId = "533";
- - public const string RubyRingId = "534";
- - public const string WeddingRingId = "801";
- - public const string CrabshellRingId = "810";
- - public const string NapalmRingId = "811";
- - public const string ThornsRingId = "839";
- - public const string LuckyRingId = "859";
- - public const string HotJavaRingId = "860";
- - public const string ProtectiveRingId = "861";
- - public const string SoulSapperRingId = "862";
- - public const string PhoenixRingId = "863";
- - public const string CombinedRingId = "880";
- - public const string ImmunityBandId = "887";
- - public const string GlowstoneRingId = "888";
- - public readonly NetInt price = new NetInt();
- - public int? obsolete_indexInTileSheet;
- - public string description;
- - public string displayName;
- - public string lightSourceId;
- - public override string TypeDefinitionId { get; } = "(O)";
- - public override string DisplayName
- - public Ring()
- - public Ring(string itemId)
- - public override bool CanBeLostOnDeath()
- - public override void onEquip(Farmer who)
- - public override void onUnequip(Farmer who)
- - public override void AddEquipmentEffects(BuffEffects effects)
- - public override string getCategoryName()
- - public virtual void onNewLocation(Farmer who, GameLocation environment)
- - public virtual void onLeaveLocation(Farmer who, GameLocation environment)
- - public override int salePrice(bool ignoreProfitMargins = false)
- - public virtual void onMonsterSlay(Monster monster, GameLocation location, Farmer who)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public virtual void update(GameTime time, GameLocation environment, Farmer who)
- - public override int maximumStackSize()
- - public override Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
- - public virtual bool GetsEffectOfRing(string ringId)
- - public virtual int GetEffectsOfRingMultiplier(string ringId)
- - public override void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
- - public override string getDescription()
- - public override bool isPlaceable()
- - public virtual bool CanCombine(Ring ring)
- - public Ring Combine(Ring ring)

## Private Members
- *(None)*

## Protected Members
- - protected override void MigrateLegacyItemId()
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected virtual bool loadDisplayFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
