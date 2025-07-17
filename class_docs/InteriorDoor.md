# InteriorDoor

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public GameLocation Location;
- - public Point Position;
- - public TemporaryAnimatedSprite Sprite;
- - public Tile Tile;
- - public InteriorDoor()
- - public InteriorDoor(GameLocation location, Point position)
- - public override void Set(bool newValue)
- - public void ResetLocalState()
- - public virtual void ApplyMapModifications()
- - public void CleanUpLocalState()
- - public void Update(GameTime time)
- - public void Draw(SpriteBatch b)

## Private Members
- - private void closeDoorSprite()
- - private void openDoorSprite()
- - private void openDoorTiles()
- - private void closeDoorTiles()

## Protected Members
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
