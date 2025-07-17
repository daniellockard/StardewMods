# FlyingCompanion

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int VARIANT_FAIRY = 0;
- - public const int VARIANT_PARROT = 1;
- - public FlyingCompanion()
- - public FlyingCompanion(int whichVariant, int whichSubVariant = -1)
- - public override void InitNetFields()
- - public override void Draw(SpriteBatch b)
- - public override void Update(GameTime time, GameLocation location)
- - public override void InitializeCompanion(Farmer farmer)
- - public override void CleanupCompanion()
- - public override void OnOwnerWarp()
- - public override void Hop(float amount)

## Private Members
- - private float flitTimer;
- - private Vector2 extraPosition;
- - private Vector2 extraPositionMotion;
- - private Vector2 extraPositionAcceleration;
- - private bool floatup;
- - private int flapAnimationLength = 4;
- - private int currentSidewaysFlap;
- - private bool hasLight = true;
- - private string lightId;
- - private NetInt whichSubVariant = new NetInt(-1);
- - private NetInt startingYForVariant = new NetInt(0);
- - private bool perching;
- - private float timeSinceLastZeroLerp;
- - private float parrot_squawkTimer;
- - private float parrot_squatTimer;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
