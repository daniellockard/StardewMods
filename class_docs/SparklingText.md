# SparklingText

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static int maxDistanceForSparkle = 32;
- - public string text;
- - public float offsetDecay = 1f;
- - public float alpha = 1f;
- - public float textWidth;
- - public float drawnTextWidth;
- - public float layerDepth = 1f;
- - public SparklingText(SpriteFont font, string text, Color color, Color sparkleColor, bool rainbow = false, double sparkleFrequency = 0.1, int millisecondsDuration = 2500, int amplitude = -1, int speed = 500, float depth = 1f)
- - public bool update(GameTime time)
- - public void draw(SpriteBatch b, Vector2 onScreenPosition)

## Private Members
- - private SpriteFont font;
- - private Color color;
- - private Color sparkleColor;
- - private bool rainbow;
- - private int millisecondsDuration;
- - private int amplitude;
- - private int period;
- - private int colorCycle;
- - private float[] individualCharacterOffsets;
- - private double sparkleFrequency;
- - private TemporaryAnimatedSpriteList sparkles;
- - private Rectangle boundingBox;
- - private void incrementRainbowColors()
- - private static Color getRainbowColorFromIndex(int index)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
