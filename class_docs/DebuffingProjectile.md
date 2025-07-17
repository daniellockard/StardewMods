# DebuffingProjectile

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetString debuff = new NetString();
- - public NetBool wavyMotion = new NetBool(value: true);
- - public NetInt debuffIntensity = new NetInt(-1);
- - public DebuffingProjectile()
- - public DebuffingProjectile(string debuff, int spriteIndex, int bouncesTillDestruct, int tailLength, float rotationVelocity, float xVelocity, float yVelocity, Vector2 startingPosition, GameLocation location = null, Character owner = null, bool hitsMonsters = false, bool playDefaultSoundOnFire = true)
- - public override void updatePosition(GameTime time)
- - public override bool update(GameTime time, GameLocation location)
- - public override void behaviorOnCollisionWithPlayer(GameLocation location, Farmer player)
- - public override void behaviorOnCollisionWithTerrainFeature(TerrainFeature t, Vector2 tileLocation, GameLocation location)
- - public override void behaviorOnCollisionWithOther(GameLocation location)
- - public override void behaviorOnCollisionWithMonster(NPC n, GameLocation location)

## Private Members
- - private float periodicEffectTimer;

## Protected Members
- - protected override void InitNetFields()
- - protected virtual void explosionAnimation(GameLocation location)

## Internal Members
- *(None)*

## Other Members
- *(None)*
