# Racer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetBool moving = new NetBool();
- - public Vector2? lastPosition;
- - public NetPosition position = new NetPosition();
- - public NetInt direction = new NetInt();
- - public float horizontalPosition = -1f;
- - public int currentTrackIndex = -1;
- - public Vector2 segmentStart = Vector2.Zero;
- - public Vector2 segmentEnd = Vector2.Zero;
- - public NetVector2 jumpSegmentStart = new NetVector2();
- - public NetVector2 jumpSegmentEnd = new NetVector2();
- - public NetBool jumping = new NetBool();
- - public NetBool tripping = new NetBool();
- - public NetBool drawAboveMap = new NetBool();
- - public float moveSpeed = 3f;
- - public float minMoveSpeed = 3f;
- - public float maxMoveSpeed = 6f;
- - public float height;
- - public float tripTimer;
- - public NetInt racerIndex = new NetInt();
- - public bool frame;
- - public float nextFrameSwap;
- - public float burstDuration;
- - public float nextBurst;
- - public float extraLuck;
- - public float gravity;
- - public int _tripLeaps;
- - public float progress;
- - public NetInt sabotages = new NetInt(0);
- - public NetFields NetFields { get; } = new NetFields("DesertFestival.Racer");
- - public Racer()
- - public Racer(int index)
- - public virtual void ResetMoveSpeed()
- - public virtual void UpdateRaceProgress(DesertFestival location)
- - public virtual void Update(DesertFestival location)
- - public virtual void SpeedBurst()
- - public virtual void Draw(SpriteBatch sb)

## Private Members
- - private void InitNetFields()

## Protected Members
- - protected Texture2D _texture;

## Internal Members
- *(None)*

## Other Members
- *(None)*
