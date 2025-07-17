# Beach

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool bridgeFixed = new NetBool();
- - public NetMutex derbyMutex = new NetMutex();
- - public Beach()
- - public Beach(string mapPath, string name)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void cleanupBeforePlayerExit()
- - public override void DayUpdate(int dayOfMonth)
- - public void doneWithBridgeFix()
- - public void fadedForBridgeFix()
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
- - public override void checkForMusic(GameTime time)
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public override void MakeMapModifications(bool force = false)
- - public override void drawOverlays(SpriteBatch b)
- - public static void showCommunityUpgradeShortcuts(GameLocation location, ref bool flag)
- - public static void fixBridge(GameLocation location)
- - public override void draw(SpriteBatch b)

## Private Members
- - private NPC oldMariner;
- - private bool hasShownCCUpgrade;
- - private void adjustDerbyFisherman(NPC npc)

## Protected Members
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
