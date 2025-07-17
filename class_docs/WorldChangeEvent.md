# WorldChangeEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public const int identifier = 942066;
- - public const int jojaGreenhouse = 0;
- - public const int junimoGreenHouse = 1;
- - public const int jojaBoiler = 2;
- - public const int junimoBoiler = 3;
- - public const int jojaBridge = 4;
- - public const int junimoBridge = 5;
- - public const int jojaBus = 6;
- - public const int junimoBus = 7;
- - public const int jojaBoulder = 8;
- - public const int junimoBoulder = 9;
- - public const int jojaMovieTheater = 10;
- - public const int junimoMovieTheater = 11;
- - public const int movieTheaterLightning = 12;
- - public const int willyBoatRepair = 13;
- - public const int treehouseBuild = 14;
- - public const int goldenParrots = 15;
- - public readonly NetInt whichEvent = new NetInt();
- - public GameLocation preEventLocation;
- - public WorldChangeEvent()
- - public WorldChangeEvent(int which)
- - public override void initNetFields()
- - public override bool setUp()
- - public void resetForPlayerEntry(Point targetTile)
- - public virtual void ParrotFlyAway()
- - public virtual void ParrotSquawk()
- - public virtual void ParrotStopSquawk()
- - public virtual void FinishTreehouse()
- - public void ParrotBounce(TemporaryAnimatedSprite sprite)
- - public void GoldenParrotBounce(TemporaryAnimatedSprite sprite)
- - public override bool tickUpdate(GameTime time)
- - public override void makeChangesToLocation()
- - public void endEvent()

## Private Members
- - private int cutsceneLengthTimer;
- - private int timerSinceFade;
- - private int soundTimer;
- - private int soundInterval = 99999;
- - private GameLocation location;
- - private string sound;
- - private bool wasRaining;
- - private void obliterateJojaMartDoor()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
