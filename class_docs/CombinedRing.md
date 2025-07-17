# CombinedRing

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetList<Ring, NetRef<Ring>> combinedRings = new NetList<Ring, NetRef<Ring>>();
- - public CombinedRing()
- - public override bool GetsEffectOfRing(string ringId)
- - public override int GetEffectsOfRingMultiplier(string ringId)
- - public override void onEquip(Farmer who)
- - public override void onUnequip(Farmer who)
- - public override void AddEquipmentEffects(BuffEffects effects)
- - public override void onLeaveLocation(Farmer who, GameLocation environment)
- - public override void onMonsterSlay(Monster m, GameLocation location, Farmer who)
- - public override void onNewLocation(Farmer who, GameLocation environment)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)
- - public override void update(GameTime time, GameLocation environment, Farmer who)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override bool loadDisplayFields()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)
- - protected virtual void OnCombinedRingsChanged()

## Internal Members
- *(None)*

## Other Members
- *(None)*
