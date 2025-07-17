# Railroad

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int trainSoundDelay = 15000;
- - public readonly NetRef<Train> train = new NetRef<Train>();
- - public readonly NetInt trainTimer = new NetInt(0);
- - public static ICue trainLoop;
- - public readonly NetBool witchStatueGone = new NetBool(value: false);
- - public Railroad()
- - public Railroad(string map, string name)
- - public override void ResetForEvent(Event ev)
- - public override void MakeMapModifications(bool force = false)
- - public override void cleanupBeforePlayerExit()
- - public override string checkForBuriedItem(int xLocation, int yLocation, bool explosion, bool detectOnly, Farmer who)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void DayUpdate(int dayOfMonth)
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
- - public void setTrainComing(int delay)
- - public void PlayTrainApproach()
- - public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
- - public override bool isTileFishable(int tileX, int tileY)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
- - public override void draw(SpriteBatch b)

## Private Members
- - private const double TrainChance = 0.09;
- - private readonly NetBool hasTrainPassed = new NetBool(value: false);
- - private int trainTime = -1;
- - private static double DailyTrainChance;
- - private void StartTrainLoopIfNeeded()

## Protected Members
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- - internal void ResetTrainForNewDay()

## Other Members
- - static Railroad()
