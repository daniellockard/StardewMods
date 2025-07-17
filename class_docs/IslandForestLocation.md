# IslandForestLocation

**Summary:** Represents a place or area in the game world.

## Public Members
- - public IslandForestLocation()
- - public IslandForestLocation(string map, string name)
- - public override void tryToAddCritters(bool onlyIfOnScreen = false)
- - public override void cleanupBeforePlayerExit()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void draw(SpriteBatch b)
- - public virtual void DrawRays(SpriteBatch b)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)

## Private Members
- - private List<Wisp> _wisps;
- - private List<WeatherDebris> weatherDebris;

## Protected Members
- - protected Color _ambientLightColor = Color.White;
- - protected Texture2D _rayTexture;
- - protected int _raySeed;
- - protected override void resetLocalState()
- - protected void _updateWoodsLighting()

## Internal Members
- *(None)*

## Other Members
- *(None)*
