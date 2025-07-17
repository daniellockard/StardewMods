# MapSeat

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static Texture2D mapChairTexture;
- - public NetLongDictionary<int, NetInt> sittingFarmers = new NetLongDictionary<int, NetInt>();
- - public NetVector2 tilePosition = new NetVector2();
- - public NetVector2 size = new NetVector2();
- - public NetInt direction = new NetInt();
- - public NetVector2 drawTilePosition = new NetVector2(new Vector2(-1f, -1f));
- - public NetBool seasonal = new NetBool();
- - public NetString seatType = new NetString();
- - public NetString textureFile = new NetString(null);
- - public string _loadedTextureFile;
- - public Texture2D overlayTexture;
- - public int localSittingDirection = 2;
- - public Vector3? customDrawValues;
- - public NetFields NetFields { get; } = new NetFields("MapSeat");
- - public MapSeat()
- - public static MapSeat FromData(string data, int x, int y)
- - public bool IsBlocked(GameLocation location)
- - public bool IsSittingHere(Farmer who)
- - public bool HasSittingFarmers()
- - public List<Vector2> GetSeatPositions(bool ignore_offsets = false)
- - public virtual void Draw(SpriteBatch b)
- - public bool OccupiesTile(int x, int y)
- - public virtual Vector2? AddSittingFarmer(Farmer who)
- - public bool IsSeatHere(GameLocation location)
- - public int GetSittingDirection()
- - public Vector2? GetSittingPosition(Farmer who, bool ignore_offsets = false)
- - public virtual Rectangle GetSeatBounds()
- - public virtual void RemoveSittingFarmer(Farmer farmer)
- - public virtual int GetSittingFarmerCount()
- - public interface ISoundBank : IDisposable

## Private Members
- - private void CheckSeatOccupancyIfTemporaryMap(Farmer who, List<Vector2> seatPositions, out bool[] seatsFilled)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
