# SoundInTheNightEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public const int cropCircle = 0;
- - public const int meteorite = 1;
- - public const int dogs = 2;
- - public const int owl = 3;
- - public const int earthquake = 4;
- - public const int raccoonStump = 5;
- - public SoundInTheNightEvent()
- - public SoundInTheNightEvent(int which)
- - public override void initNetFields()
- - public override bool setUp()
- - public override bool tickUpdate(GameTime time)
- - public override void draw(SpriteBatch b)
- - public override void makeChangesToLocation()

## Private Members
- - private readonly NetInt behavior = new NetInt();
- - private float timer;
- - private float timeUntilText = 7000f;
- - private string soundName;
- - private string message;
- - private bool playedSound;
- - private bool showedMessage;
- - private bool finished;
- - private Vector2 targetLocation;
- - private Building targetBuilding;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
