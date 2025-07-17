# Ghost

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum GhostVariant
- - public const float rotationIncrement = (float)Math.PI / 64f;
- - public int wasHitCounter;
- - public float targetRotation;
- - public bool turningRight;
- - public int identifier = Game1.random.Next(-99999, 99999);
- - public new int yOffset;
- - public int yOffsetExtra;
- - public string lightSourceId;
- - public NetInt currentState = new NetInt(0);
- - public float stateTimer = -1f;
- - public float nextParticle;
- - public NetEnum<GhostVariant> variant = new NetEnum<GhostVariant>(GhostVariant.Normal);
- - public Ghost()
- - public Ghost(Vector2 position)
- - public Ghost(Vector2 position, string name)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override int GetBaseDifficultyLevel()
- - public override List<Item> getExtraDropItems()
- - public override void drawAboveAllLayers(SpriteBatch b)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public virtual bool UpdateVariantAnimation(GameTime time)
- - public override void noMovementProgressNearPlayerBehavior()
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void localDeathAnimation()
- - protected override void sharedDeathAnimation()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
