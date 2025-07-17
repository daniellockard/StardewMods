# CaveCrystal

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 tileLocation;
- - public int id;
- - public int pitch;
- - public Color color;
- - public Color currentColor;
- - public float shakeTimer;
- - public float glowTimer;
- - public void update()
- - public void activate()
- - public void draw(SpriteBatch b)
- - public const string lightSourceId = "IslandWestCave1";
- - public const int PHASE_INTRO = 0;
- - public const int PHASE_PLAY_SEQUENCE = 1;
- - public const int PHASE_WAIT_FOR_PLAYER_INPUT = 2;
- - public const int PHASE_NOTHING = 3;
- - public const int PHASE_SUCCESSFUL_SEQUENCE = 4;
- - public const int PHASE_OUTRO = 5;
- - public NetBool completed = new NetBool();
- - public NetBool isActivated = new NetBool(value: false);
- - public NetFloat netPhaseTimer = new NetFloat();
- - public float localPhaseTimer;
- - public float betweenNotesTimer;
- - public int localPhase;
- - public NetInt netPhase = new NetInt(3);
- - public NetInt currentDifficulty = new NetInt(2);
- - public NetInt currentCrystalSequenceIndex = new NetInt(0);
- - public int currentPlaybackCrystalSequenceIndex;
- - public NetInt timesFailed = new NetInt(0);
- - public NetList<int, NetInt> currentCrystalSequence = new NetList<int, NetInt>();
- - public NetEvent1Field<int, NetInt> enterValueEvent = new NetEvent1Field<int, NetInt>();
- - public IslandWestCave1()
- - public IslandWestCave1(string map, string name)
- - public void onActivationChanged(NetBool field, bool old_value, bool new_value)
- - public void resetPuzzle()
- - public override void MakeMapModifications(bool force = false)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public virtual void updateActivationVisuals()
- - public virtual void UpdateActivationTiles()
- - public virtual void enterValue(int which)
- - public override void cleanupBeforePlayerExit()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public void addCompletionTorches()
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected List<CaveCrystal> crystals = new List<CaveCrystal>();
- - protected override void initNetFields()
- - protected override void resetSharedState()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
