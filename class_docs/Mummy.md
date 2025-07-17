# Mummy

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetInt reviveTimer = new NetInt(0);
- - public const int revivalTime = 10000;
- - public Mummy()
- - public Mummy(Vector2 position)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public override void defaultMovementBehavior(GameTime time)
- - public override List<Item> getExtraDropItems()
- - public override void update(GameTime time, GameLocation location)
- - public override void behaviorAtGameTick(GameTime time)

## Private Members
- - private readonly NetEvent1Field<bool, NetBool> crumbleEvent = new NetEvent1Field<bool, NetBool>();
- - private void crumble(bool reverse = false)
- - private void performCrumble(bool reverse)
- - private List<FarmerSprite.AnimationFrame> getCrumbleAnimation(bool reverse = false)
- - private void behaviorAfterCrumble(Farmer who)
- - private void behaviorAfterRevival(Farmer who)

## Protected Members
- - protected int _damageToFarmer;
- - protected override void initNetFields()
- - protected override void sharedDeathAnimation()
- - protected override void localDeathAnimation()
- - protected override void updateAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
