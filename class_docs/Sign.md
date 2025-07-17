# Sign

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int OBJECT = 1;
- - public const int HAT = 2;
- - public const int BIG_OBJECT = 3;
- - public const int RING = 4;
- - public const int FURNITURE = 5;
- - public readonly NetRef<Item> displayItem = new NetRef<Item>();
- - public readonly NetInt displayType = new NetInt();
- - public override string TypeDefinitionId => "(BC)";
- - public Sign()
- - public Sign(Vector2 tile, string itemId)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
- - public override bool ForEachItem(ForEachItemDelegate handler, GetForEachItemPathDelegate getPath)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
