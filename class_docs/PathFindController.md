# PathFindController

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public delegate bool isAtEnd(PathNode currentNode, Point endPoint, GameLocation location, Character c);
- - public delegate void endBehavior(Character c, GameLocation location);
- - public const byte impassable = byte.MaxValue;
- - public const int timeToWaitBeforeCancelling = 5000;
- - public GameLocation location;
- - public Stack<Point> pathToEndPoint;
- - public Point endPoint;
- - public int finalFacingDirection;
- - public int pausedTimer;
- - public endBehavior endBehaviorFunction;
- - public bool nonDestructivePathing;
- - public bool allowPlayerPathingInEvent;
- - public bool NPCSchedule;
- - public int timerSinceLastCheckPoint;
- - public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection)
- - public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection, endBehavior endBehaviorFunction)
- - public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection, endBehavior endBehaviorFunction, int limit)
- - public PathFindController(Character c, GameLocation location, Point endPoint, int finalFacingDirection, bool clearMarriageDialogues = true)
- - public static bool isAtEndPoint(PathNode currentNode, Point endPoint, GameLocation location, Character c)
- - public PathFindController(Stack<Point> pathToEndPoint, GameLocation location, Character c, Point endPoint)
- - public PathFindController(Stack<Point> pathToEndPoint, Character c, GameLocation l)
- - public PathFindController(Character c, GameLocation location, isAtEnd endFunction, int finalFacingDirection, endBehavior endBehaviorFunction, int limit, Point endPoint, bool clearMarriageDialogues = true)
- - public bool isPlayerPresent()
- - public virtual bool update(GameTime time)
- - public static Stack<Point> findPath(Point startPoint, Point endPoint, isAtEnd endPointFunction, GameLocation location, Character character, int limit)
- - public static Stack<Point> reconstructPath(PathNode finalNode)
- - public void handleWarps(Rectangle position)
- - public static Stack<Point> findPathForNPCSchedules(Point startPoint, Point endPoint, GameLocation location, int limit)
- - public static Stack<Point> findPathForNPCSchedules(Point startPoint, Point endPoint, GameLocation location, int limit, Character npc)

## Private Members
- - private Character character;

## Protected Members
- - protected static readonly sbyte[,] Directions = new sbyte[4, 2]
- - protected static PriorityQueue _openList = new PriorityQueue();
- - protected static HashSet<int> _closedList = new HashSet<int>();
- - protected static int _counter = 0;
- - protected virtual void moveCharacter(GameTime time)
- - protected static bool isPositionImpassableForNPCSchedule(GameLocation loc, int x, int y, Character npc)
- - protected static int getPreferenceValueForTerrainType(GameLocation l, int x, int y)

## Internal Members
- *(None)*

## Other Members
- *(None)*
