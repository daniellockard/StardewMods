# Shooter

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetBool shooting = new NetBool();
- - public int shotsLeft;
- - public float nextShot;
- - public int projectileSpeed = 12;
- - public string projectileDebuff = "26";
- - public int numberOfShotsPerFire = 1;
- - public float aimTime = 0.25f;
- - public float burstTime = 0.25f;
- - public float aimEndTime = 1f;
- - public int firedProjectile = 12;
- - public string damageSound = "shadowHit";
- - public string fireSound = "Cowboy_gunshot";
- - public int projectileRange = 10;
- - public int desiredDistance = 5;
- - public int fireRange = 8;
- - public NetEvent0 fireEvent = new NetEvent0();
- - public Shooter()
- - public override int GetBaseDifficultyLevel()
- - public virtual void OnFire()
- - public override bool ShouldActuallyMoveAwayFromPlayer()
- - public Shooter(Vector2 position)
- - public Shooter(Vector2 position, string monster_name)
- - public virtual void InitializeVariant()
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void behaviorAtGameTick(GameTime time)
- - public override void updateMovement(GameLocation location, GameTime time)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void update(GameTime time, GameLocation location)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void updateAnimation(GameTime time)
- - protected override void localDeathAnimation()
- - protected override void sharedDeathAnimation()

## Internal Members
- *(None)*

## Other Members
- *(None)*
