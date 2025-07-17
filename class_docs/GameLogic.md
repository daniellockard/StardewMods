# GameLogic

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum GameStates
- - public List<Item> collectedItems;
- - public const int CLAW_HEIGHT = 50;
- - public int maxLives = 3;
- - public int lives = 3;
- - public Vector2 _startPosition = new Vector2(24f, 56f);
- - public Vector2 _dropPosition = new Vector2(32f, 56f);
- - public Rectangle playArea = new Rectangle(16, 48, 272, 64);
- - public Rectangle prizeChute = new Rectangle(16, 48, 32, 32);
- - public CraneGameObject moveRightIndicator;
- - public CraneGameObject moveDownIndicator;
- - public CraneGameObject creditsDisplay;
- - public CraneGameObject timeDisplay1;
- - public CraneGameObject timeDisplay2;
- - public CraneGameObject sunShockedFace;
- - public int currentTimer;
- - public CraneGameObject joystick;
- - public int[] conveyerBeltTiles = new int[68]
- - public int[] prizeMap = new int[68]
- - public GameLogic(CraneGame game)
- - public GameStates GetCurrentState()
- - public override void Update(GameTime time)
- - public override void Draw(SpriteBatch b, float layer_depth)
- - public void SetState(GameStates new_state)

## Private Members
- *(None)*

## Protected Members
- - protected Claw _claw;
- - protected GameStates _currentState;
- - protected int _stateTimer;

## Internal Members
- *(None)*

## Other Members
- *(None)*
