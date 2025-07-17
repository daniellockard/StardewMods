# Submarine

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float submergeTime = 20000f;
- - public const string MainTileSheetId = "submarine tiles";
- - public readonly NetBool submerged = new NetBool();
- - public readonly NetBool ascending = new NetBool();
- - public Submarine()
- - public Submarine(string mapPath, string name)
- - public override void draw(SpriteBatch b)
- - public override void DayUpdate(int dayOfMonth)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public override bool canFishHere()
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void cleanupBeforePlayerExit()

## Private Members
- - private Texture2D submarineSprites;
- - private float curtainMovement;
- - private float curtainOpenPercent;
- - private float submergeTimer;
- - private Color ambientLightTargetColor;
- - private bool hasLitSubmergeLight;
- - private bool hasLitAscendLight;
- - private bool doneUntilReset;
- - private bool localAscending;
- - private void changeSubmergeLight(bool red, bool clear = false)

## Protected Members
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
