# PlayerCoupleBirthingEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public PlayerCoupleBirthingEvent()
- - public override bool setUp()
- - public void returnBabyName(string name)
- - public void afterMessage()
- - public override bool tickUpdate(GameTime time)

## Private Members
- - private int timer;
- - private string soundName;
- - private string message;
- - private string babyName;
- - private bool playedSound;
- - private bool isMale;
- - private bool getBabyName;
- - private bool naming;
- - private FarmHouse farmHouse;
- - private long spouseID;
- - private Farmer spouse;
- - private bool isPlayersTurn;
- - private Child child;
- - private bool isSuitableHome(FarmHouse home)
- - private FarmHouse chooseHome()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
