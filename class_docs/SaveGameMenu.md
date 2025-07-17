# SaveGameMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public bool quit;
- - public bool hasDrawn;
- - public SaveGameMenu()
- - public void complete()
- - public override bool readyToClose()
- - public override void update(GameTime time)
- - public override void draw(SpriteBatch b)
- - public void Dispose()

## Private Members
- - private IEnumerator<int> loader;
- - private int completePause = -1;
- - private SparklingText saveText;
- - private int margin = 500;
- - private StringBuilder _stringBuilder = new StringBuilder();
- - private float _ellipsisDelay = 0.5f;
- - private int _ellipsisCount;
- - private static void saveClientOptions()

## Protected Members
- - protected bool _hasSentFarmhandData;

## Internal Members
- *(None)*

## Other Members
- *(None)*
