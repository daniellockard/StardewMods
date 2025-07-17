# Butterfly

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float maxSpeed = 3f;
- - public bool stayInbounds;
- - public bool isPrismatic;
- - public bool isLit;
- - public Butterfly(GameLocation location, Vector2 position, bool islandButterfly = false, bool forceSummerButterfly = false, int baseFrameOverride = -1, bool prismatic = false)
- - public void doneWithFlap(Farmer who)
- - public Butterfly setStayInbounds(bool stayInbounds)
- - public override bool update(GameTime time, GameLocation environment)
- - public override void draw(SpriteBatch b)
- - public override void drawAboveFrontLayer(SpriteBatch b)

## Private Members
- - private int flapTimer;
- - private int flapSpeed = 50;
- - private Vector2 motion;
- - private float motionMultiplier = 1f;
- - private float prismaticCaptureTimer = -1f;
- - private float prismaticSprinkleTimer;
- - private bool summerButterfly;
- - private string lightId;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
