# NPCController

**Summary:** Represents a non-player character (villager, merchant, etc.).

## Public Members
- - public delegate void endBehavior();
- - public Character puppet;
- - public NPCController(Character n, List<Vector2> path, bool loop, endBehavior endBehavior = null)
- - public void destroyAtNextCrossroad()
- - public bool update(GameTime time, GameLocation location, List<NPCController> allControllers)
- - public interface ICustomEventScript

## Private Members
- - private bool loop;
- - private bool destroyAtNextTurn;
- - private List<Vector2> path;
- - private Vector2 target;
- - private int pathIndex;
- - private int pauseTime = -1;
- - private int speed;
- - private endBehavior behaviorAtEnd;
- - private int CurrentPathX
- - private int CurrentPathY
- - private bool MovingHorizontally => CurrentPathX != 0;
- - private bool setMoving(bool newTarget)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
