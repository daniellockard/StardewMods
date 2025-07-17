# Item

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public const string ErrorItemName = "Error Item";
- - public bool isLostItem;
- - public readonly NetInt category = new NetInt();
- - public readonly NetBool hasbeenInInventory = new NetBool();
- - public Dictionary<string, object> tempData;
- - public string SetFlagOnPickup;
- - public readonly NetString netName = new NetString("Error Item");
- - public readonly NetInt parentSheetIndex = new NetInt();
- - public NetString itemId = new NetString();
- - public bool specialItem;
- - public readonly NetBool isRecipe = new NetBool();
- - public readonly NetInt quality = new NetInt(0);
- - public readonly NetInt stack = new NetInt(1);
- - public ModDataDictionary modData { get; } = new ModDataDictionary();
- - public ModDataDictionary modDataForSerialization
- - public int SpecialVariable
- - public int Category
- - public bool HasBeenInInventory
- - public NetFields NetFields { get; } = new NetFields("Item");
- - public int ParentSheetIndex
- - public abstract string TypeDefinitionId { get; }
- - public string ItemId
- - public string QualifiedItemId
- - public abstract string DisplayName { get; }
- - public virtual string Name
- - public virtual string BaseName => Name;
- - public virtual int Stack
- - public int Quality
- - public bool IsRecipe
- - public bool IsInfiniteStock()
- - public void MarkContextTagsDirty()
- - public HashSet<string> GetContextTags()
- - public bool HasContextTag(string tag)
- - public virtual bool ShouldSerializeparentSheetIndex()
- - public void ResetParentSheetIndex()
- - public string GetItemTypeId()
- - public virtual void drawTooltip(SpriteBatch spriteBatch, ref int x, ref int y, SpriteFont font, float alpha, StringBuilder overrideText)
- - public virtual void ModifyItemBuffs(BuffEffects buffs)
- - public virtual Point getExtraSpaceNeededForTooltipSpecialIcons(SpriteFont font, int minWidth, int horizontalBuffer, int startingHeight, StringBuilder descriptionText, string boldTitleText, int moneyAmountToDisplayAtBottom)
- - public bool ShouldDrawIcon()
- - public abstract void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow);
- - public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber)
- - public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth)
- - public void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize)
- - public abstract int maximumStackSize();
- - public void AdjustMenuDrawForRecipes(ref float transparency, ref float scale)
- - public virtual void DrawMenuIcons(SpriteBatch sb, Vector2 location, float scale_size, float transparency, float layer_depth, StackDrawType drawStackNumber, Color color)
- - public virtual void DrawIconBar(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color)
- - public virtual int addToStack(Item otherStack)
- - public abstract string getDescription();
- - public abstract bool isPlaceable();
- - public virtual int sellToStorePrice(long specificPlayerID = -1L)
- - public virtual int salePrice(bool ignoreProfitMargins = false)
- - public virtual bool appliesProfitMargins()
- - public virtual bool CanBeLostOnDeath()
- - public virtual bool canBeTrashed()
- - public virtual bool actionWhenPurchased(string shopId)
- - public bool LearnRecipe(Farmer player = null)
- - public virtual bool CanBuyItem(Farmer who)
- - public virtual bool canBeDropped()
- - public virtual bool canBeShipped()
- - public virtual void onDetachedFromParent()
- - public virtual void onEquip(Farmer who)
- - public virtual void onUnequip(Farmer who)
- - public virtual void actionWhenBeingHeld(Farmer who)
- - public virtual void actionWhenStopBeingHeld(Farmer who)
- - public int getRemainingStackSpace()
- - public virtual Item? ConsumeStack(int amount)
- - public virtual int healthRecoveredOnConsumption()
- - public virtual int staminaRecoveredOnConsumption()
- - public virtual string getHoverBoxText(Item hoveredItem)
- - public virtual bool canBeGivenAsGift()
- - public virtual void drawAttachments(SpriteBatch b, int x, int y)
- - public virtual bool canBePlacedHere(GameLocation l, Vector2 tile, CollisionMask collisionMask = CollisionMask.All, bool showError = false)
- - public virtual int attachmentSlots()
- - public virtual string getCategoryName()
- - public virtual Color getCategoryColor()
- - public virtual bool canStackWith(ISalable other)
- - public virtual string checkForSpecialItemHoldUpMeessage()
- - public Item getOne()
- - public void CopyFieldsFrom(Item source)
- - public ISalable GetSalableInstance()
- - public virtual int CompareTo(object other)
- - public int getCategorySortValue()
- - public void SetTempData<T>(string key, T value)
- - public bool TryGetTempData<T>(string key, out T value)
- - public virtual void FixStackSize()
- - public virtual void FixQuality()
- - public virtual void resetState()
- - public virtual bool HasEquipmentBuffs()
- - public virtual void AddEquipmentEffects(BuffEffects effects)
- - public virtual IEnumerable<Buff> GetFoodOrDrinkBuffs()
- - public virtual string GenerateLightSourceId(Farmer heldBy)
- - public virtual bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)

## Private Members
- - private readonly NetInt specialVariable = new NetInt();
- - private HashSet<string> _contextTags;

## Protected Members
- - protected bool _contextTagsDirty;
- - protected string _qualifiedItemId;
- - protected void _GenerateContextTags()
- - protected virtual void _PopulateContextTags(HashSet<string> tags)
- - protected Item()
- - protected virtual void MigrateLegacyItemId()
- - protected virtual void initNetFields()
- - protected string ValidateUnqualifiedItemId(string id)
- - protected abstract Item GetOneNew();
- - protected virtual void GetOneCopyFrom(Item source)
- - protected virtual int getDescriptionWidth()

## Internal Members
- *(None)*

## Other Members
- *(None)*
