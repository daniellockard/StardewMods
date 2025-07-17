# IslandSouthEast

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Texture2D mermaidSprites;
- - public int lastPlayedNote = -1;
- - public int songIndex = -1;
- - public int[] mermaidIdle = new int[1];
- - public int[] mermaidWave = new int[4] { 1, 1, 2, 2 };
- - public int[] mermaidReward = new int[7] { 3, 3, 3, 3, 3, 4, 4 };
- - public int[] mermaidDance = new int[6] { 5, 5, 5, 6, 6, 6 };
- - public int mermaidFrameIndex;
- - public int[] currentMermaidAnimation;
- - public float mermaidFrameTimer;
- - public float mermaidDanceTime;
- - public NetEvent0 mermaidPuzzleSuccess = new NetEvent0();
- - public NetBool mermaidPuzzleFinished = new NetBool();
- - public NetEvent0 fishWalnutEvent = new NetEvent0();
- - public NetBool fishedWalnut = new NetBool();
- - public IslandSouthEast()
- - public IslandSouthEast(string map, string name)
- - public virtual void OnMermaidPuzzleSuccess()
- - public override void MakeMapModifications(bool force = false)
- - public override void cleanupBeforePlayerExit()
- - public override void SetBuriedNutLocations()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public bool MermaidIsHere()
- - public override void draw(SpriteBatch b)
- - public override Item getFish(float millisecondsAfterNibble, string bait, int waterDepth, Farmer who, double baitPotency, Vector2 bobberTile, string locationName = null)
- - public void OnFishWalnut()
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public virtual void OnFlutePlayed(int pitch)

## Private Members
- - private const string lightId = "IslandSouthEast";

## Protected Members
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
