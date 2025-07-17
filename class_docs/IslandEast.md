# IslandEast

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetBool bananaShrineComplete = new NetBool();
- - public NetBool bananaShrineNutAwarded = new NetBool();
- - public IslandEast()
- - public IslandEast(string map, string name)
- - public virtual void AddTorchLights()
- - public override void cleanupBeforePlayerExit()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public virtual void SpawnBananaNutReward()
- - public override void DayUpdate(int dayOfMonth)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public virtual void AddGorillaShrineTorches(int delay)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public virtual void OnBananaShrine()
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)

## Private Members
- - private void gorillaReachedShrine(int extra)
- - private void gorillaReachedShrineCosmetic(int extra)
- - private void gorillaGrabBanana(int extra)
- - private void gorillaEatBanana(int extra)
- - private void gorillaAfterEat(int extra)
- - private void gorillaSpawnNut(int extra)
- - private void gorillaReturn(int extra)

## Protected Members
- - protected PerchingBirds _parrots;
- - protected Texture2D _parrotTextures;
- - protected NetEvent0 bananaShrineEvent = new NetEvent0();
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
