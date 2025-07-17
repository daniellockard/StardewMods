# Chunk

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int MinSinkTimer = 1900;
- - public const int MaxSinkTimer = 2400;
- - public NetPosition position = new NetPosition();
- - public readonly NetFloat xVelocity = new NetFloat().Interpolated(interpolate: true, wait: true);
- - public readonly NetFloat yVelocity = new NetFloat().Interpolated(interpolate: true, wait: true);
- - public readonly NetBool hasPassedRestingLineOnce = new NetBool(value: false);
- - public int bounces;
- - public float bob;
- - public readonly NetInt sinkTimer = new NetInt();
- - public readonly NetInt netDebrisType = new NetInt();
- - public bool hitWall;
- - public readonly NetInt xSpriteSheet = new NetInt();
- - public readonly NetInt ySpriteSheet = new NetInt();
- - public float rotation;
- - public float rotationVelocity;
- - public int randomOffset
- - public float scale
- - public float alpha
- - public NetFields NetFields { get; } = new NetFields("Chunk");
- - public Chunk()
- - public Chunk(Vector2 position, float xVelocity, float yVelocity, int random_offset)
- - public float getSpeed()
- - public Vector2 GetVisualPosition()

## Private Members
- - private readonly NetFloat netScale = new NetFloat().Interpolated(interpolate: true, wait: true);
- - private readonly NetFloat netAlpha = new NetFloat();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
