# IslandFieldOffice

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int totalPieces = 11;
- - public const int piece_Skeleton_Back_Leg = 0;
- - public const int piece_Skeleton_Ribs = 1;
- - public const int piece_Skeleton_Front_Leg = 2;
- - public const int piece_Skeleton_Tail = 3;
- - public const int piece_Skeleton_Spine = 4;
- - public const int piece_Skeleton_Skull = 5;
- - public const int piece_Snake_Tail = 6;
- - public const int piece_Snake_Spine = 7;
- - public const int piece_Snake_Skull = 8;
- - public const int piece_Bat = 9;
- - public const int piece_Frog = 10;
- - public NetList<Item, NetRef<Item>> uncollectedRewards = new NetList<Item, NetRef<Item>>();
- - public NetMutex safariGuyMutex = new NetMutex();
- - public NetList<bool, NetBool> piecesDonated = new NetList<bool, NetBool>(11);
- - public readonly NetBool centerSkeletonRestored = new NetBool
- - public readonly NetBool snakeRestored = new NetBool
- - public readonly NetBool batRestored = new NetBool
- - public readonly NetBool frogRestored = new NetBool
- - public readonly NetBool plantsRestoredLeft = new NetBool
- - public readonly NetBool plantsRestoredRight = new NetBool
- - public readonly NetBool hasFailedSurveyToday = new NetBool();
- - public IslandFieldOffice()
- - public IslandFieldOffice(string map, string name)
- - public NPC getSafariGuy()
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public bool donatePiece(int which)
- - public bool isRangeAllTrue(int low, int high)
- - public void triggerFinaleCutscene()
- - public override void draw(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public virtual void OnCollectReward(Item item, Farmer farmer)
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public override void DayUpdate(int dayOfMonth)
- - public virtual void TalkToSafariGuy()
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)

## Private Members
- - private NPC safariGuy;
- - private bool _shouldTriggerFinalCutscene;
- - private float speakerTimer;
- - private void ApplyPlantRestoreLeft()
- - private void ApplyPlantRestoreRight()
- - private void ApplyFrogRestore()
- - private void ApplyBatRestore()
- - private void ApplySnakeRestore()
- - private void ApplySkeletonRestore()
- - private void _triggerFinaleCutsceneActual()
- - private int getRandomUnfoundBoneIndex()

## Protected Members
- - protected override void initNetFields()
- - protected override void resetLocalState()
- - protected void _StartFinaleEvent()

## Internal Members
- *(None)*

## Other Members
- *(None)*
