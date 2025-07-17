# BasicProjectile

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public delegate void onCollisionBehavior(GameLocation location, int xPosition, int yPosition, Character who);
- - public readonly NetInt damageToFarmer = new NetInt();
- - public readonly NetString collisionSound = new NetString();
- - public readonly NetBool explode = new NetBool();
- - public onCollisionBehavior collisionBehavior;
- - public NetString debuff = new NetString(null);
- - public NetString debuffSound = new NetString("debuffHit");
- - public BasicProjectile()
- - public BasicProjectile(int damageToFarmer, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition, string collisionSound = null, string bounceSound = null, string firingSound = null, bool explode = false, bool damagesMonsters = false, GameLocation location = null, Character firer = null, onCollisionBehavior collisionBehavior = null, string shotItemId = null)
- - public BasicProjectile(int damageToFarmer, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition)
- - public override void updatePosition(GameTime time)
- - public override void behaviorOnCollisionWithPlayer(GameLocation location, Farmer player)
- - public override void behaviorOnCollisionWithTerrainFeature(TerrainFeature t, Vector2 tileLocation, GameLocation location)
- - public override void behaviorOnCollisionWithOther(GameLocation location)
- - public override void behaviorOnCollisionWithMonster(NPC n, GameLocation location)
- - public static void explodeOnImpact(GameLocation location, int x, int y, Character who)
- - public virtual Farmer GetPlayerWhoFiredMe(GameLocation location)

## Private Members
- *(None)*

## Protected Members
- - protected override void InitNetFields()
- - protected virtual void explosionAnimation(GameLocation location)

## Internal Members
- *(None)*

## Other Members
- *(None)*
