# IslandActivityAssigments

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int activityTime;
- - public List<NPC> visitors;
- - public Dictionary<Character, string> currentAssignments;
- - public Dictionary<Character, string> currentAnimationAssignments;
- - public Random random;
- - public Dictionary<string, string> animationDescriptions;
- - public List<Point> shoreLoungePoints = new List<Point>((IEnumerable<Point>)(object)new Point[6]
- - public List<Point> chairPoints = new List<Point>((IEnumerable<Point>)(object)new Point[2]
- - public List<Point> umbrellaPoints = new List<Point>((IEnumerable<Point>)(object)new Point[3]
- - public List<Point> towelLoungePoints = new List<Point>((IEnumerable<Point>)(object)new Point[4]
- - public List<Point> drinkPoints = new List<Point>((IEnumerable<Point>)(object)new Point[2]
- - public List<Point> wanderPoints = new List<Point>((IEnumerable<Point>)(object)new Point[3]
- - public IslandActivityAssigments(int time, List<NPC> visitors, Random seeded_random, Dictionary<Character, string> last_activity_assignments)
- - public virtual void FindActivityForCharacters(Dictionary<Character, string> last_activity_assignments)
- - public bool TryAssignment(Character character, List<Point> points, string dialogue_key, string animation_name = null, bool animation_required = false, double chance = 1.0, Dictionary<Character, string> last_activity_assignments = null)
- - public string GetRandomDialogueKey(string dialogue_key, Random random)
- - public string GetScheduleStringForCharacter(NPC character)
- - public Texture2D boatTexture;
- - public Vector2 boatPosition;
- - public LightSource boatLight;
- - public LightSource boatStringLight;
- - public readonly NetBool shouldToggleResort = new NetBool(value: false);
- - public readonly NetBool resortOpenToday = new NetBool(value: true);
- - public readonly NetBool resortRestored = new NetBool
- - public readonly NetBool westernTurtleMoved = new NetBool();
- - public NetEvent0 moveTurtleEvent = new NetEvent0();
- - public IslandSouth()
- - public IslandSouth(string map, string name)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override void DayUpdate(int dayOfMonth)
- - public void ApplyResortRestore()
- - public void ApplyWesternTurtleMove()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void cleanupBeforePlayerExit()
- - public override bool isCollidingPosition(Rectangle position, Rectangle viewport, bool isFarmer, int damagesFarmer, bool glider, Character character)
- - public override bool isTilePlaceable(Vector2 tileLocation, bool itemIsPassable = false)
- - public override void MakeMapModifications(bool force = false)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public static bool CanVisitIslandToday(NPC npc)
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override void performTouchAction(string[] action, Vector2 playerStandingPosition)
- - public void Depart()
- - public static Point GetDressingRoomPoint(NPC character)
- - public override bool HasLocationOverrideDialogue(NPC character)
- - public override string GetLocationOverrideDialogue(NPC character)
- - public static bool HasIslandAttire(NPC character)
- - public static void SetupIslandSchedules()
- - public virtual void ResetBoat()
- - public Vector2 GetBoatPosition()
- - public override void draw(SpriteBatch b)
- - public override bool RunLocationSpecificEventCommand(Event current_event, string command_string, bool first_run, params string[] args)

## Private Members
- - private Rectangle turtle1Spot = new Rectangle(1088, 0, 192, 192);
- - private Rectangle turtle2Spot = new Rectangle(0, 640, 256, 256);
- - private void parrotBoyLands(int extra)

## Protected Members
- - protected int _boatDirection;
- - protected int _boatOffset;
- - protected float _nextBubble;
- - protected float _nextSlosh;
- - protected float _nextSmoke;
- - protected bool _parrotBoyHiding;
- - protected bool _isFirstVisit;
- - protected bool _exitsBlocked;
- - protected bool _sawFlameSprite;
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
