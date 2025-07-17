# FarmerWarp

**Summary:** Represents the player character, including stats, inventory, and actions.

## Public Members
- - public Farmer who;
- - public string name;
- - public int facingDirection;
- - public short x;
- - public short y;
- - public bool isStructure;
- - public bool warpingForForcedRemoteEvent;
- - public FarmerWarp(Farmer who, short x, short y, string name, bool isStructure, int facingDirection, bool warpingForForcedRemoteEvent)
- - public bool CheckedHostPrecondition;
- - public bool FakeWarp
- - public Farmer FakeFarmer
- - public DedicatedServer()
- - public void Reset()
- - public void ResetForNewDay()
- - public void DoHostAction(string action, params object[] data)
- - public void Tick()
- - public void ProcessMessage(IncomingMessage message)
- - public interface INetCompression

## Private Members
- - private const string BROADCAST_EVENT_KEY = "BroadcastEvent";
- - private readonly ConcurrentQueue<FarmerWarp> farmerWarps = new ConcurrentQueue<FarmerWarp>();
- - private readonly Dictionary<string, Dictionary<string, long>> eventLocks = new Dictionary<string, Dictionary<string, long>>();
- - private readonly HashSet<long> onlineIds = new HashSet<long>();
- - private readonly HashSet<string> broadcastEvents = new HashSet<string>();
- - private readonly HashSet<string> notBroadcastEvents = new HashSet<string>();
- - private bool fakeWarp;
- - private bool warpingSleep;
- - private bool warpingFestival;
- - private bool warpingHostBroadcastEvent;
- - private bool startedFestivalMainEvent;
- - private bool startedFestivalEnd;
- - private bool shouldJudgeGrange;
- - private long fakeFarmerId;
- - private bool TryForceClientHostEvent(FarmerWarp warp, GameLocation location, string eventId)
- - private void CheckForWarpEvents(FarmerWarp warp)
- - private bool IsWarping()
- - private bool CheckOthersReady(string readyCheck)
- - private void HostSleepInBed()
- - private void ProcessEventDone(IncomingMessage message)
- - private void ProcessHostAction(IncomingMessage message)

## Protected Members
- *(None)*

## Internal Members
- - internal void HandleFarmerWarp(FarmerWarp warp)

## Other Members
- *(None)*
