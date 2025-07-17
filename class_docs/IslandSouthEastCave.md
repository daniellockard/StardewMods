# IslandSouthEastCave

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetLongList drinksClaimed = new NetLongList();
- - public bool wasPirateCaveOnLoad;
- - public IslandSouthEastCave()
- - public IslandSouthEastCave(string map, string name)
- - public override void updateMap()
- - public override void MakeMapModifications(bool force = false)
- - public static bool isWearingPirateClothes(Farmer who)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public override void cleanupBeforePlayerExit()
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override void DayUpdate(int dayOfMonth)
- - public override void SetBuriedNutLocations()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public static bool isPirateNight()
- - public override void TransferDataFromSavedLocation(GameLocation l)

## Private Members
- - private float smokeTimer;
- - private void addFlame(Vector2 tileLocation, float sort_offset_tiles = 2.25f)

## Protected Members
- - protected PerchingBirds _parrots;
- - protected Texture2D _parrotTextures;
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
