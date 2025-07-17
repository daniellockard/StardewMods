# SandDuggy

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum State
- - public NetList<Point, NetPoint> holeLocations = new NetList<Point, NetPoint>();
- - public int frame;
- - public NetInt currentHoleIndex = new NetInt(0);
- - public int _localIndex;
- - public NetLocationRef locationRef = new NetLocationRef();
- - public State currentState;
- - public Texture2D texture;
- - public float nextFrameUpdate;
- - public NetBool whacked = new NetBool(value: false);
- - public NetFields NetFields { get; } = new NetFields("SandDuggy");
- - public SandDuggy()
- - public SandDuggy(GameLocation location, Point[] points)
- - public virtual int FindRandomFreePoint()
- - public virtual void InitNetFields()
- - public virtual void OnWhackedChanged(NetBool field, bool old_value, bool new_value)
- - public virtual void AnimateWhacked()
- - public virtual void ResetForPlayerEntry()
- - public virtual void PerformToolAction(Tool tool, int tile_x, int tile_y)
- - public virtual bool NearFarmer(Point location, Farmer farmer)
- - public virtual void Update(GameTime time)
- - public virtual void Draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
