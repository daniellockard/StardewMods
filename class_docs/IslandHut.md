# IslandHut

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetBool treeNutObtained = new NetBool();
- - public NetEvent0 hitTreeEvent = new NetEvent0();
- - public NetEvent0 parrotBoyEvent = new NetEvent0();
- - public bool treeHitLocal;
- - public readonly NetBool firstParrotDone = new NetBool();
- - public List<string> hintDialogues = new List<string>();
- - public NetString hintForToday = new NetString(null);
- - public float hintShowTime = -1f;
- - public float hintShakeTime = -1f;
- - public override void draw(SpriteBatch b)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public virtual int ShowNutHint()
- - public virtual void Squawk()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public IslandHut()
- - public IslandHut(string map, string name)
- - public override bool performToolAction(Tool t, int tileX, int tileY)
- - public override void DayUpdate(int dayOfMonth)
- - public virtual void SpitTreeNut()
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)

## Private Members
- - private void ParrotBoyEvent_onEvent()

## Protected Members
- - protected virtual bool MissingLimitedNutDrops(ref int running_total, string key, int count = 1)
- - protected virtual bool MissingTheseNuts(ref int running_total, params string[] keys)
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
