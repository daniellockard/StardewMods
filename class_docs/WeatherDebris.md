# WeatherDebris

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int pinkPetals = 0;
- - public const int greenLeaves = 1;
- - public const int fallLeaves = 2;
- - public const int snow = 3;
- - public const int animationInterval = 100;
- - public const float gravity = -0.5f;
- - public Vector2 position;
- - public Rectangle sourceRect;
- - public int which;
- - public int animationIndex;
- - public int animationTimer = 100;
- - public int animationDirection = 1;
- - public int animationIntervalOffset;
- - public float dx;
- - public float dy;
- - public static float globalWind = -0.25f;
- - public WeatherDebris(Vector2 position, int which, float rotationVelocity, float dx, float dy)
- - public void update()
- - public void update(bool slow)
- - public void draw(SpriteBatch b)

## Private Members
- - private bool blowing;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
