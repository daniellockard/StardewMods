# Boots

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetInt defenseBonus = new NetInt();
- - public readonly NetInt immunityBonus = new NetInt();
- - public readonly NetInt indexInTileSheet = new NetInt();
- - public readonly NetInt price = new NetInt();
- - public readonly NetInt indexInColorSheet = new NetInt();
- - public readonly NetString appliedBootSheetIndex = new NetString();
- - public string displayName;
- - public string description;
- - public override string TypeDefinitionId { get; } = "(B)";
- - public override string DisplayName
- - public Boots()
- - public Boots(string itemId)
- - public virtual void reloadData()
- - public void applyStats(Boots applied_boots)
- - public virtual string getStatsIndex()
- - public override int salePrice(bool ignoreProfitMargins = false)
- - public override void onEquip(Farmer who)
- - public override void onUnequip(Farmer who)
- - public override void AddEquipmentEffects(BuffEffects effects)
- - public string GetBootsColorString()
- - public int getNumberOfDescriptionCategories()
- - public override void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
- - public override Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override int maximumStackSize()
- - public override string getCategoryName()
- - public override string getDescription()
- - public override bool isPlaceable()

## Private Members
- *(None)*

## Protected Members
- - protected override void MigrateLegacyItemId()
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)
- - protected virtual bool loadDisplayFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
