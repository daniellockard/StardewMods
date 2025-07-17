# DesertFestival

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum RaceState
- - public const int CALICO_STATUE_GHOST_INVASION = 0;
- - public const int CALICO_STATUE_SERPENT_INVASION = 1;
- - public const int CALICO_STATUE_SKELETON_INVASION = 2;
- - public const int CALICO_STATUE_BAT_INVASION = 3;
- - public const int CALICO_STATUE_ASSASSIN_BUGS = 4;
- - public const int CALICO_STATUE_THIN_SHELLS = 5;
- - public const int CALICO_STATUE_MEAGER_MEALS = 6;
- - public const int CALICO_STATUE_MONSTER_SURGE = 7;
- - public const int CALICO_STATUE_SHARP_TEETH = 8;
- - public const int CALICO_STATUE_MUMMY_CURSE = 9;
- - public const int CALICO_STATUE_SPEED_BOOST = 10;
- - public const int CALICO_STATUE_REFRESH = 11;
- - public const int CALICO_STATUE_50_EGG_TREASURE = 12;
- - public const int CALICO_STATUE_NO_EFFECT = 13;
- - public const int CALICO_STATUE_TOOTH_FILE = 14;
- - public const int CALICO_STATUE_25_EGG_TREASURE = 15;
- - public const int CALICO_STATUE_10_EGG_TREASURE = 16;
- - public const int CALICO_STATUE_100_EGG_TREASURE = 17;
- - public static readonly int[] CalicoStatueInvasionIds = new int[4] { 3, 0, 1, 2 };
- - public const int NUM_SCHOLAR_QUESTIONS = 4;
- - public const string FISHING_QUEST_ID = "98765";
- - public NetList<Racer, NetRef<Racer>> netRacers = new NetList<Racer, NetRef<Racer>>();
- - public List<int> finishedRacers = new List<int>();
- - public int racerCount = 3;
- - public int totalRacers = 5;
- - public NetEvent1Field<string, NetString> announceRaceEvent = new NetEvent1Field<string, NetString>();
- - public NetEnum<RaceState> currentRaceState = new NetEnum<RaceState>(RaceState.PreRace);
- - public NetLongDictionary<int, NetInt> sabotages = new NetLongDictionary<int, NetInt>();
- - public NetLongDictionary<int, NetInt> raceGuesses = new NetLongDictionary<int, NetInt>();
- - public NetLongDictionary<int, NetInt> nextRaceGuesses = new NetLongDictionary<int, NetInt>();
- - public NetLongDictionary<bool, NetBool> specialRewardsCollected = new NetLongDictionary<bool, NetBool>();
- - public NetLongDictionary<int, NetInt> rewardsToCollect = new NetLongDictionary<int, NetInt>();
- - public NetInt lastRaceWinner = new NetInt();
- - public Vector3[][] raceTrack = new Vector3[16][]
- - public DesertFestival()
- - public DesertFestival(string mapPath, string name)
- - public static void SetupMerchantSchedule(NPC character, int shop_index)
- - public override void OnCamel()
- - public override void ShowCamelAnimation()
- - public override void checkForMusic(GameTime time)
- - public virtual string GetFestivalMusic()
- - public override string GetLocationSpecificMusic()
- - public override void digUpArtifactSpot(int xLocation, int yLocation, Farmer who)
- - public virtual void CollectRacePrizes()
- - public override void performTouchAction(string full_action_string, Vector2 player_standing_position)
- - public virtual string GetMakeoverEvent()
- - public virtual void ReceiveMakeOver(int randomSeedOverride = -1)
- - public virtual void AfterMakeOver()
- - public NPC GetStylist()
- - public static void addCalicoStatueSpeedBuff()
- - public override bool performAction(string action, Farmer who, Location tile_location)
- - public string GetCactusMail()
- - public string GetScholarMail()
- - public virtual Response[] GetRacerResponses()
- - public virtual void ShowSabotagedRaceText()
- - public override void customQuestCompleteBehavior(string questId)
- - public override bool answerDialogueAction(string question_and_answer, string[] question_params)
- - public void CactusGuyHideCactus(int seed)
- - public void CactusGuyRevealCactus(int seed)
- - public bool CanMakeAnotherRaceGuess()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public void OnRaceWon(int winner)
- - public void AddSmokePuff(Vector2 v)
- - public static void CleanupFestival()
- - public override void draw(SpriteBatch spriteBatch)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void drawOverlays(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch sb)
- - public Vector3 GetTrackPosition(int track_index, float horizontal_position)
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public virtual void AnnounceRace(string text)
- - public override void DayUpdate(int dayOfMonth)
- - public override void cleanupBeforePlayerExit()
- - public static void SetupFestivalDay()

## Private Members
- - private bool checkedMineExplanation;
- - private void ReceiveMakeOver()
- - private void generateNextScholarQuestion()

## Protected Members
- - protected RandomizedPlantFurniture _cactusGuyRevealItem;
- - protected float _cactusGuyRevealTimer = -1f;
- - protected float _cactusShakeTimer = -1f;
- - protected int _currentlyShownCactusID;
- - protected NetEvent1Field<int, NetInt> _revealCactusEvent = new NetEvent1Field<int, NetInt>();
- - protected NetEvent1Field<int, NetInt> _hideCactusEvent = new NetEvent1Field<int, NetInt>();
- - protected MoneyDial eggMoneyDial;
- - protected List<Racer> _localRacers = new List<Racer>();
- - protected float festivalChimneyTimer;
- - protected float _raceStateTimer;
- - protected string _raceText;
- - protected float _raceTextTimer;
- - protected bool _raceTextShake;
- - protected int _localSabotageText = -1;
- - protected int _currentScholarQuestion = -1;
- - protected int _cookIngredient = -1;
- - protected int _cookSauce = -1;
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
