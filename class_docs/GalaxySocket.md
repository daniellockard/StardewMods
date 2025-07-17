# GalaxySocket

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const long Timeout = 30000L;
- - public const string ProtocolVersionKey = "protocolVersion";
- - public const string HostNameDataKey = "HostDisplayName";
- - public const string SteamHostIdDataKey = "SteamHostId";
- - public const string SteamLobbyIdDataKey = "SteamLobbyId";
- - public bool isRecreatedLobby;
- - public bool isFirstRecreateAttempt;
- - public int ConnectionCount => connections.Count;
- - public IEnumerable<GalaxyID> Connections => connections.Values;
- - public bool Connected => lobby != (GalaxyID)null;
- - public GalaxyID LobbyOwner => lobbyOwner;
- - public GalaxyID Lobby => lobby;
- - public ulong? InviteDialogLobby => null;
- - public GalaxySocket(string protocolVersion)
- - public string GetInviteCode()
- - public long GetPingWith(GalaxyID peer)
- - public void SetPrivacy(ServerPrivacy privacy)
- - public void CreateLobby(ServerPrivacy privacy, uint memberLimit)
- - public void JoinLobby(GalaxyID lobbyId, Action<string> onError)
- - public void SetLobbyData(string key, string value)
- - public IEnumerable<GalaxyID> LobbyMembers()
- - public void Kick(GalaxyID user)
- - public void Close()
- - public void Receive(Action<GalaxyID> onConnection, Action<GalaxyID, Stream> onMessage, Action<GalaxyID> onDisconnect, Action<string> onError)
- - public virtual void DisconnectPeers(Action<GalaxyID> onDisconnect)
- - public void Heartbeat(IEnumerable<GalaxyID> peers)
- - public void Send(GalaxyID peer, byte[] data)
- - public void Send(GalaxyID peer, OutgoingMessage message)

## Private Members
- - private const int SendMaxPacketSize = 1100;
- - private const int ReceiveMaxPacketSize = 1300;
- - private const long RecreateLobbyDelay = 20000L;
- - private const long HeartbeatDelay = 8L;
- - private const byte HeartbeatMessage = byte.MaxValue;
- - private GalaxyID selfId;
- - private GalaxyID connectingLobbyID;
- - private GalaxyID lobby;
- - private GalaxyID lobbyOwner;
- - private GalaxyLobbyEnteredListener galaxyLobbyEnterCallback;
- - private GalaxyLobbyCreatedListener galaxyLobbyCreatedCallback;
- - private GalaxyLobbyLeftListener galaxyLobbyLeftCallback;
- - private GalaxyLobbyMemberStateListener galaxyLobbyMemberStateCallback;
- - private string protocolVersion;
- - private bool checkedProcotolVersion;
- - private Dictionary<string, string> lobbyData = new Dictionary<string, string>();
- - private ServerPrivacy privacy;
- - private uint memberLimit;
- - private long recreateTimer;
- - private long heartbeatTimer;
- - private Dictionary<ulong, GalaxyID> connections = new Dictionary<ulong, GalaxyID>();
- - private HashSet<ulong> ghosts = new HashSet<ulong>();
- - private Dictionary<ulong, MemoryStream> incompletePackets = new Dictionary<ulong, MemoryStream>();
- - private string getConnectionString()
- - private long getTimeNow()
- - private LobbyType privacyToLobbyType(ServerPrivacy privacy)
- - private void tryCreateLobby()
- - private void updateLobbyPrivacy()
- - private void OnLobbyCreateFailed()
- - private void onGalaxyLobbyCreated(GalaxyID lobbyID, LobbyCreateResult result)
- - private void onGalaxyMemberState(GalaxyID lobbyID, GalaxyID memberID, LobbyMemberStateChange memberStateChange)
- - private unsafe void onGalaxyLobbyLeft(GalaxyID lobbyID, LobbyLeaveReason leaveReason)
- - private void onGalaxyLobbyEnter(GalaxyID lobbyID, LobbyEnterResult result)
- - private void close(GalaxyID peer)
- - private void PreprocessMessage(GalaxyID peer, MemoryStream stream, Action<GalaxyID, Stream> onMessage)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
