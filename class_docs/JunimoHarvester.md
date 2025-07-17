# JunimoHarvester

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int whichJunimoFromThisHut;
- - public readonly NetBool isPrismatic = new NetBool(value: false);
- - public Guid HomeId
- - public JunimoHut home
- - public override bool IsVillager => false;
- - public JunimoHarvester()
- - public JunimoHarvester(GameLocation location, Vector2 position, JunimoHut hut, int whichJunimoNumberFromThisHut, Color? c)
- - public override void ChooseAppearance(LocalizedContentManager content = null)
- - public virtual void reachFirstDestinationFromHut(Character c, GameLocation l)
- - public virtual void tryToHarvestHere()
- - public virtual void pokeToHarvest()
- - public override bool shouldCollideWithBuildingLayer(GameLocation location)
- - public void setMoving(int xSpeed, int ySpeed)
- - public void setMoving(Vector2 motion)
- - public override void Halt()
- - public override bool canTalk()
- - public void junimoReachedHut(Character c, GameLocation l)
- - public virtual bool foundCropEndFunction(PathNode currentNode, Point endPoint, GameLocation location, Character c)
- - public virtual void pathfindToNewCrop()
- - public virtual void returnToJunimoHut(GameLocation location)
- - public override void faceDirection(int direction)
- - public override void update(GameTime time, GameLocation location)
- - public virtual void pathfindToRandomSpotAroundHut()
- - public virtual void tryToAddItemToHut(Item i)
- - public override void draw(SpriteBatch b, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- - protected float alpha = 1f;
- - protected float alphaChange;
- - protected Vector2 motion = Vector2.Zero;
- - protected new Rectangle nextPosition;
- - protected readonly NetColor color = new NetColor();
- - protected bool destroy;
- - protected Item lastItemHarvested;
- - protected int harvestTimer;
- - protected readonly NetGuid netHome = new NetGuid();
- - protected readonly NetEvent1Field<int, NetInt> netAnimationEvent = new NetEvent1Field<int, NetInt>();
- - protected virtual void pickColor()
- - protected override void initNetFields()
- - protected virtual void doAnimationEvent(int animId)
- - protected override void updateSlaveAnimation(GameTime time)
- - protected virtual bool isHarvestable()

## Internal Members
- *(None)*

## Other Members
- *(None)*
