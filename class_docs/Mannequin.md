# Mannequin

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string displayNameOverride;
- - public readonly NetMutex changeMutex = new NetMutex();
- - public readonly NetRef<Hat> hat = new NetRef<Hat>();
- - public readonly NetRef<Clothing> shirt = new NetRef<Clothing>();
- - public readonly NetRef<Clothing> pants = new NetRef<Clothing>();
- - public readonly NetRef<Boots> boots = new NetRef<Boots>();
- - public readonly NetDirection facing = new NetDirection();
- - public readonly NetBool swappedWithFarmerTonight = new NetBool();
- - public override string TypeDefinitionId { get; } = "(M)";
- - public Mannequin()
- - public Mannequin(string itemId)
- - public override string getDescription()
- - public override bool isPlaceable()
- - public override bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who = null)
- - public override bool minutesElapsed(int minutes)
- - public override void actionOnPlayerEntry()
- - public override void DayUpdate()
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override bool performToolAction(Tool t)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- - private Farmer renderCache;
- - private void OnMannequinUpdated<TNetField, TValue>(TNetField field, TValue oldValue, TValue newValue)
- - private void emitGhost()
- - private void DropItem(Item item)
- - private Farmer GetFarmerForRendering()

## Protected Members
- - protected string _description;
- - protected MannequinData _data;
- - protected override void initNetFields()
- - protected internal MannequinData GetMannequinData()
- - protected override string loadDisplayName()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)

## Internal Members
- - internal int eyeTimer;

## Other Members
- *(None)*
