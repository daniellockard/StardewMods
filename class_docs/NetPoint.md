# NetPoint

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public int X
- - public int Y
- - public NetPoint()
- - public NetPoint(Point value)
- - public void Set(int x, int y)
- - public override void Set(Point newValue)

## Private Members
- *(None)*

## Protected Members
- - protected override Point interpolate(Point startValue, Point endValue, float factor)
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
