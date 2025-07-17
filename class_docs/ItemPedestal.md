# ItemPedestal

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public NetMutex itemModifyMutex = new NetMutex();
- - public NetRef<Object> requiredItem = new NetRef<Object>();
- - public NetColor successColor = new NetColor();
- - public NetBool lockOnSuccess = new NetBool();
- - public NetBool locked = new NetBool();
- - public NetBool match = new NetBool();
- - public readonly NetBool isIslandShrinePedestal = new NetBool();
- - public Texture2D texture;
- - public override string TypeDefinitionId => "(BC)";
- - public ItemPedestal()
- - public ItemPedestal(Vector2 tile, Object required_item, bool lock_on_success, Color success_color, string itemId = "221")
- - public override bool performObjectDropInAction(Item dropInItem, bool probe, Farmer who, bool returnFalseIfItemConsumed = false)
- - public virtual void UpdateItemMatch()
- - public override bool checkForAction(Farmer who, bool checking_for_activity = false)
- - public bool DropObject(Farmer who)
- - public override bool performToolAction(Tool t)
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override bool onExplosion(Farmer who)
- - public override void DayUpdate()
- - public override void draw(SpriteBatch b, int x, int y, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)

## Internal Members
- *(None)*

## Other Members
- *(None)*
