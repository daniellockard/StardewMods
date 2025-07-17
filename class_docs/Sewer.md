# Sewer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float steamZoom = 4f;
- - public const float steamYMotionPerMillisecond = 0.1f;
- - public Sewer()
- - public Sewer(string map, string name)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void MakeMapModifications(bool force = false)

## Private Members
- - private Texture2D steamAnimation;
- - private Vector2 steamPosition;
- - private Color steamColor = new Color(200, 255, 200);

## Protected Members
- - protected override void resetSharedState()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
