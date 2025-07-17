# LightSource

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum LightContext
- - public const int lantern = 1;
- - public const int windowLight = 2;
- - public const int sconceLight = 4;
- - public const int cauldronLight = 5;
- - public const int indoorWindowLight = 6;
- - public const int projectorLight = 7;
- - public const int fishTankLight = 8;
- - public const int townWinterTreeLight = 9;
- - public const int pinpointLight = 10;
- - public readonly NetInt textureIndex = new NetInt().Interpolated(interpolate: false, wait: false);
- - public Texture2D lightTexture;
- - public readonly NetVector2 position = new NetVector2().Interpolated(interpolate: true, wait: true);
- - public readonly NetColor color = new NetColor();
- - public readonly NetFloat radius = new NetFloat();
- - public readonly NetString netId = new NetString();
- - public readonly NetEnum<LightContext> lightContext = new NetEnum<LightContext>();
- - public readonly NetLong playerID = new NetLong(0L).Interpolated(interpolate: false, wait: false);
- - public readonly NetInt fadeOut = new NetInt(-1);
- - public readonly NetString onlyLocation = new NetString();
- - public string Id
- - public long PlayerID
- - public NetFields NetFields { get; } = new NetFields("LightSource");
- - public LightSource()
- - public LightSource(string id, int textureIndex, Vector2 position, float radius, Color color, LightContext lightContext = LightContext.None, long playerID = 0L, string onlyLocation = null)
- - public LightSource(string id, int textureIndex, Vector2 position, float radius, LightContext lightContext = LightContext.None, long playerID = 0L, string onlyLocation = null)
- - public bool IsOnScreen()
- - public virtual void Draw(SpriteBatch spriteBatch, GameLocation location, float lightMultiplier)
- - public LightSource Clone()

## Private Members
- - private void loadTextureFromConstantValue(int value)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
