# NetRectangle

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public int X
- - public int Y
- - public int Width
- - public int Height
- - public Point Center => ((Rectangle)(ref value)).Center;
- - public int Top => ((Rectangle)(ref value)).Top;
- - public int Bottom => ((Rectangle)(ref value)).Bottom;
- - public int Left => ((Rectangle)(ref value)).Left;
- - public int Right => ((Rectangle)(ref value)).Right;
- - public NetRectangle()
- - public NetRectangle(Rectangle value)
- - public void Set(int x, int y, int width, int height)
- - public override void Set(Rectangle newValue)

## Private Members
- *(None)*

## Protected Members
- - protected override void ReadDelta(BinaryReader reader, NetVersion version)
- - protected override void WriteDelta(BinaryWriter writer)

## Internal Members
- *(None)*

## Other Members
- *(None)*
