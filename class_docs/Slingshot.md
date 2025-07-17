# Slingshot

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int basicDamage = 5;
- - public const string basicSlingshotId = "32";
- - public const string masterSlingshotId = "33";
- - public const string galaxySlingshotId = "34";
- - public const int drawBackSoundThreshold = 8;
- - public int lastClickX;
- - public int lastClickY;
- - public int mouseDragAmount;
- - public double pullStartTime = -1.0;
- - public float nextAutoFire = -1f;
- - public bool canPlaySound;
- - public readonly NetPoint aimPos = new NetPoint().Interpolated(interpolate: true, wait: true);
- - public override string TypeDefinitionId { get; } = "(W)";
- - public Slingshot()
- - public override bool doesShowTileLocationMarker()
- - public Slingshot(string itemId = "32")
- - public int GetBackArmDistance(Farmer who)
- - public override void DoFunction(GameLocation location, int x, int y, int power, Farmer who)
- - public virtual void PerformFire(GameLocation location, Farmer who)
- - public virtual int GetAmmoDamage(Object ammunition)
- - public virtual string GetAmmoCollisionSound(Object ammunition)
- - public virtual BasicProjectile.onCollisionBehavior GetAmmoCollisionBehavior(Object ammunition)
- - public Vector2 GetShootOrigin(Farmer who)
- - public Vector2 AdjustForHeight(Vector2 position, bool for_cursor = true)
- - public void finish()
- - public override string getHoverBoxText(Item hoveredItem)
- - public override bool onRelease(GameLocation location, int x, int y, Farmer who)
- - public override bool beginUsing(GameLocation location, int x, int y, Farmer who)
- - public virtual float GetAutoFireRate()
- - public virtual bool CanAutoFire()
- - public override void tickUpdate(GameTime time, Farmer who)
- - public float GetSlingshotChargeTime()
- - public float GetRequiredChargeTime()
- - public override void draw(SpriteBatch b)
- - public override void drawInMenu(SpriteBatch spriteBatch, Vector2 location, float scaleSize, float transparency, float layerDepth, StackDrawType drawStackNumber, Color color, bool drawShadow)

## Private Members
- - private readonly NetEvent0 finishEvent = new NetEvent0();
- - private void doFinish()
- - private void updateAimPos()

## Protected Members
- - protected override void MigrateLegacyItemId()
- - protected override Item GetOneNew()
- - protected override string loadDisplayName()
- - protected override string loadDescription()
- - protected override void initNetFields()
- - protected override bool canThisBeAttached(Object o, int slot)
- - protected override void GetAttachmentSlotSprite(int slot, out Texture2D texture, out Rectangle sourceRect)

## Internal Members
- *(None)*

## Other Members
- *(None)*
