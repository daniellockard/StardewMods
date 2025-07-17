# BreathProjectile

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool active = new NetBool();
- - public readonly NetVector2 position = new NetVector2();
- - public readonly NetVector2 startPosition = new NetVector2();
- - public readonly NetVector2 velocity = new NetVector2();
- - public float rotation;
- - public float alpha;
- - public NetFields NetFields { get; } = new NetFields("BreathProjectile");
- - public BreathProjectile()
- - public Rectangle GetBoundingBox()
- - public Rectangle GetSourceRect()
- - public void ExplosionAnimation(GameLocation location)
- - public void Update(GameTime time, GameLocation location, DinoMonster parent)
- - public void Draw(SpriteBatch b)
- - public int timeUntilNextAttack;
- - public readonly NetBool firing = new NetBool(value: false);
- - public NetInt attackState = new NetInt();
- - public int nextFireTime;
- - public int totalFireTime;
- - public int nextChangeDirectionTime;
- - public int nextWanderTime;
- - public bool wanderState;
- - public readonly NetObjectArray<BreathProjectile> projectiles = new NetObjectArray<BreathProjectile>(15);
- - public int lastProjectileSlot;
- - public DinoMonster()
- - public DinoMonster(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void draw(SpriteBatch b)
- - public override Rectangle GetBoundingBox()
- - public override List<Item> getExtraDropItems()
- - public override bool ShouldMonsterBeRemoved()
- - public override void update(GameTime time, GameLocation location)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()
- - protected override void localDeathAnimation()
- - protected override void updateAnimation(GameTime time)
- - protected override void updateMonsterSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
