# ChestHitSynchronizer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public void Reset()
- - public void Update()
- - public void Sync(ChestHitArgs args)
- - public void SignalMove(GameLocation location, int sourceTileX, int sourceTileY, int destTileX, int destTileY)
- - public void SignalDelete(GameLocation location, int tileX, int tileY)
- - public void ProcessMessage(IncomingMessage message)

## Private Members
- - private readonly Queue<ChestHitArgs> EventQueue = new Queue<ChestHitArgs>();
- - private static GameLocation ReadLocation(IncomingMessage message)
- - private void ProcessSync(IncomingMessage message)
- - private void ProcessMove(IncomingMessage message)
- - private void ProcessDelete(IncomingMessage message)

## Protected Members
- *(None)*

## Internal Members
- - internal readonly Dictionary<string, Dictionary<ulong, ChestHitTimer>> SavedTimers = new Dictionary<string, Dictionary<ulong, ChestHitTimer>>();
- - internal static ulong HashPosition(int x, int y)

## Other Members
- *(None)*
