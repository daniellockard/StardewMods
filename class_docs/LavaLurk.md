# LavaLurk

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum State
- - public List<FarmerSprite.AnimationFrame> submergedAnimation = new List<FarmerSprite.AnimationFrame>();
- - public List<FarmerSprite.AnimationFrame> lurkAnimation = new List<FarmerSprite.AnimationFrame>();
- - public List<FarmerSprite.AnimationFrame> emergeAnimation = new List<FarmerSprite.AnimationFrame>();
- - public List<FarmerSprite.AnimationFrame> diveAnimation = new List<FarmerSprite.AnimationFrame>();
- - public List<FarmerSprite.AnimationFrame> resubmergeAnimation = new List<FarmerSprite.AnimationFrame>();
- - public List<FarmerSprite.AnimationFrame> idleAnimation = new List<FarmerSprite.AnimationFrame>();
- - public List<FarmerSprite.AnimationFrame> fireAnimation = new List<FarmerSprite.AnimationFrame>();
- - public List<FarmerSprite.AnimationFrame> locallyPlayingAnimation;
- - public bool approachFarmer;
- - public Vector2 velocity = Vector2.Zero;
- - public int swimSpeed;
- - public Farmer targettedFarmer;
- - public NetEnum<State> currentState = new NetEnum<State>();
- - public float stateTimer;
- - public float fireTimer;
- - public LavaLurk()
- - public LavaLurk(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public virtual void Initialize()
- - public virtual void OnEmergeAnimationEnd(Farmer who)
- - public virtual void OnDiveAnimationEnd(Farmer who)
- - public virtual bool PlayAnimation(List<FarmerSprite.AnimationFrame> animation_to_play, bool loop)
- - public virtual bool TargetInRange()
- - public virtual void SetRandomMovement()
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void behaviorAtGameTick(GameTime time)
- - public static bool IsLavaTile(GameLocation location, int x, int y)
- - public bool CheckInWater(Rectangle position)
- - public override void updateMovement(GameLocation location, GameTime time)
- - public override Debris ModifyMonsterLoot(Debris debris)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()
- - protected override void updateAnimation(GameTime time)
- - protected override void updateMonsterSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
