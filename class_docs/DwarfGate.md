# DwarfGate

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetPoint tilePosition = new NetPoint();
- - public NetLocationRef locationRef = new NetLocationRef();
- - public bool triggeredOpen;
- - public NetPointDictionary<bool, NetBool> switches = new NetPointDictionary<bool, NetBool>
- - public Dictionary<Point, bool> localSwitches = new Dictionary<Point, bool>();
- - public NetBool opened = new NetBool(value: false);
- - public bool localOpened;
- - public NetInt pressedSwitches = new NetInt(0)
- - public int localPressedSwitches;
- - public NetInt gateIndex = new NetInt(0);
- - public NetEvent0 openEvent = new NetEvent0();
- - public NetEvent1Field<Point, NetPoint> pressEvent = new NetEvent1Field<Point, NetPoint>
- - public NetFields NetFields { get; } = new NetFields("DwarfGate");
- - public DwarfGate()
- - public DwarfGate(VolcanoDungeon location, int gate_index, int x, int y, int seed)
- - public virtual void InitNetFields()
- - public virtual void OnPress(Point point)
- - public virtual void OpenGate()
- - public virtual void ResetLocalState()
- - public virtual void UpdateLocalStates()
- - public virtual void Draw(SpriteBatch b)
- - public virtual void UpdateWhenCurrentLocation(GameTime time, GameLocation location)
- - public virtual void ApplyTiles()

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
