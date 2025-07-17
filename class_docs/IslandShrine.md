# IslandShrine

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public ItemPedestal northPedestal;
- - public ItemPedestal southPedestal;
- - public ItemPedestal eastPedestal;
- - public ItemPedestal westPedestal;
- - public NetEvent0 puzzleFinishedEvent = new NetEvent0();
- - public NetBool puzzleFinished = new NetBool();
- - public IslandShrine()
- - public IslandShrine(string map, string name)
- - public override List<Vector2> GetAdditionalWalnutBushes()
- - public ItemPedestal AddOrUpdatePedestal(Vector2 position, string birdLocation)
- - public virtual void AddMissingPedestals()
- - public override void MakeMapModifications(bool force = false)
- - public override void TransferDataFromSavedLocation(GameLocation l)
- - public void OnPuzzleFinish()
- - public virtual void ApplyFinishedTiles()
- - public override void UpdateWhenCurrentLocation(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
