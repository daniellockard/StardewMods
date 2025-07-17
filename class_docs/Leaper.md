# Leaper

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetFloat leapDuration = new NetFloat(0.75f);
- - public NetFloat leapProgress = new NetFloat(0f);
- - public NetBool leaping = new NetBool(value: false);
- - public NetVector2 leapStartPosition = new NetVector2();
- - public NetVector2 leapEndPosition = new NetVector2();
- - public float nextLeap;
- - public Leaper()
- - public Leaper(Vector2 position)
- - public override int GetBaseDifficultyLevel()
- - public override void reloadSprite(bool onlyAppearance = false)
- - public virtual void OnLeapingChanged(NetBool field, bool old_value, bool new_value)
- - public override bool isInvincible()
- - public override void updateMovement(GameLocation location, GameTime time)
- - public override void defaultMovementBehavior(GameTime time)
- - public override void noMovementProgressNearPlayerBehavior()
- - public override void update(GameTime time, GameLocation location)
- - public virtual bool IsValidLandingTile(Vector2 tile, bool check_other_characters = false)
- - public override void behaviorAtGameTick(GameTime time)
- - public override void shedChunks(int number, float scale)

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
