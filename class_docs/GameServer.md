# GameServer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int connectionsCount => servers.Sum((Server s) => s.connectionsCount);
- - public BandwidthLogger BandwidthLogger
- - public bool LogBandwidth
- - public GameServer(bool local_multiplayer = false)
- - public bool isConnectionActive(string connectionId)
- - public virtual void onConnect(string connectionID)
- - public virtual void onDisconnect(string connectionID)
- - public bool IsLocalMultiplayerInitiatedServer()
- - public virtual void UpdateLocalOnlyFlag()
- - public string getInviteCode()
- - public string getUserName(long farmerId)
- - public float getPingToClient(long farmerId)
- - public void setPrivacy(ServerPrivacy privacy)
- - public void stopServer()
- - public void receiveMessages()
- - public void sendMessage(long peerId, OutgoingMessage message)
- - public bool canAcceptIPConnections()
- - public bool canOfferInvite()
- - public void offerInvite()
- - public bool anyServerConnected()
- - public bool connected()
- - public void sendMessage(long peerId, byte messageType, Farmer sourceFarmer, params object[] data)
- - public void sendMessages()
- - public void startServer()
- - public void initializeHost()
- - public void sendServerIntroduction(long peer)
- - public void kick(long disconnectee)
- - public string ban(long farmerId)
- - public void playerDisconnected(long disconnectee)
- - public bool isGameAvailable()
- - public bool whenGameAvailable(Action action, Func<bool> customAvailabilityCheck = null)
- - public bool isUserBanned(string userID)
- - public bool IsFarmhandAvailable(Farmer farmhand)
- - public void checkFarmhandRequest(string userId, string connectionId, NetFarmerRoot farmer, Action<OutgoingMessage> sendMessage, Action approve)
- - public void sendAvailableFarmhands(string userId, string connectionId, Action<OutgoingMessage> sendMessage)
- - public T GetServer<T>() where T : Server
- - public void processIncomingMessage(IncomingMessage message)
- - public void updateLobbyData()

## Private Members
- - private Dictionary<Action, Func<bool>> pendingGameAvailableActions = new Dictionary<Action, Func<bool>>();
- - private readonly HashSet<string> pendingAvailableFarmhands = new HashSet<string>();
- - private List<Action> completedPendingActions = new List<Action>();
- - private List<string> bannedUsers = new List<string>();
- - private void rejectFarmhandRequest(string userId, string connectionId, NetFarmerRoot farmer, Action<OutgoingMessage> sendMessage)
- - private bool authCheck(string userID, Farmer farmhand)
- - private void sendLocation(long peer, GameLocation location, bool force_current = false)
- - private void warpFarmer(Farmer farmer, short x, short y, string name, bool isStructure)
- - private void rebroadcastClientMessage(IncomingMessage message, long peerID)
- - private void setLobbyData(string key, string value)
- - private bool unclaimedFarmhandsExist()

## Protected Members
- - protected bool _wasConnected;
- - protected bool _isLocalMultiplayerInitiatedServer;
- - protected void initialize()

## Internal Members
- - internal List<Server> servers = new List<Server>();

## Other Members
- *(None)*
