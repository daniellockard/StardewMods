# SteamNetServer

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public override int connectionsCount => ConnectionDataMap?.Count ?? 0;
- - public SteamNetServer(IGameServer gameServer)
- - public override bool isConnectionActive(string connectionId)
- - public override string getUserId(long farmerId)
- - public override bool hasUserId(string userId)
- - public override string getUserName(long farmerId)
- - public override void setPrivacy(ServerPrivacy privacy)
- - public override bool connected()
- - public override void initialize()
- - public override void stopServer()
- - public override void receiveMessages()
- - public override void sendMessage(long peerId, OutgoingMessage message)
- - public override void setLobbyData(string key, string value)
- - public override void kick(long disconnectee)
- - public override void playerDisconnected(long disconnectee)
- - public override float getPingToClient(long farmerId)
- - public override bool canOfferInvite()
- - public override void offerInvite()

## Private Members
- - private const int ServerBufferSize = 256;
- - private const int FlagsLobbyEntered = 1;
- - private const int FlagsLobbyLeft = 30;
- - private CallResult<LobbyCreated_t> LobbyCreatedCallResult;
- - private Callback<SteamNetConnectionStatusChangedCallback_t> SteamNetConnectionStatusChangedCallback;
- - private Callback<LobbyChatUpdate_t> LobbyChatUpdateCallback;
- - private Dictionary<string, string> LobbyData;
- - private Dictionary<HSteamNetConnection, ConnectionData> ConnectionDataMap;
- - private Dictionary<long, ConnectionData> FarmerConnectionMap;
- - private Dictionary<CSteamID, string> CachedDisplayNames;
- - private HashSet<HSteamNetConnection> RecentlyJoined;
- - private readonly IntPtr[] Messages = new IntPtr[256];
- - private CSteamID Lobby;
- - private HSteamListenSocket ListenSocket = HSteamListenSocket.Invalid;
- - private HSteamNetPollGroup JoiningGroup = HSteamNetPollGroup.Invalid;
- - private HSteamNetPollGroup FarmhandGroup = HSteamNetPollGroup.Invalid;
- - private ServerPrivacy Privacy;
- - private void UpdateLobbyPrivacy()
- - private string ConnectionDataToId(ConnectionData connection)
- - private ConnectionData IdToConnectionData(string connectionId)
- - private void OnConnecting(SteamNetConnectionStatusChangedCallback_t evt, CSteamID steamId)
- - private void OnConnected(SteamNetConnectionStatusChangedCallback_t evt, CSteamID steamId)
- - private void OnDisconnected(SteamNetConnectionStatusChangedCallback_t evt, CSteamID steamId)
- - private void OnDisconnected(HSteamNetConnection connection)
- - private void OnSteamNetConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t evt)
- - private void OnLobbyChatUpdate(LobbyChatUpdate_t evt)
- - private string OnLobbyCreatedHelper(LobbyCreated_t evt, bool ioFailure)
- - private void OnLobbyCreated(LobbyCreated_t evt, bool ioFailure)
- - private void HandleFarmhandRequest(IncomingMessage message, ConnectionData connectionData)
- - private void PollJoiningMessages()
- - private void PollFarmhandMessages()
- - private void SendMessageToConnection(HSteamNetConnection connection, OutgoingMessage message)
- - private void ShutdownConnection(HSteamNetConnection connection)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
