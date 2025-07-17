# SteamNetClient

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public SteamNetClient(GalaxyID galaxyLobby)
- - public SteamNetClient(CSteamID steamLobby)
- - public override string getUserID()
- - public override void disconnect(bool neatly = true)
- - public override void sendMessage(OutgoingMessage message)
- - public override float GetPingToHost()

## Private Members
- - private const int ClientBufferSize = 256;
- - private CallResult<LobbyEnter_t> SteamLobbyEnterCallResult;
- - private readonly Callback<SteamNetConnectionStatusChangedCallback_t> SteamNetConnectionStatusChangedCallback;
- - private GalaxyLobbyDataRetrieveListener GalaxyLobbyDataRetrieveCallback;
- - private readonly IntPtr[] Messages = new IntPtr[256];
- - private GalaxyID GalaxyLobby;
- - private CSteamID SteamLobby;
- - private CSteamID HostId;
- - private string CachedHostName;
- - private HSteamNetConnection Connection = HSteamNetConnection.Invalid;
- - private void OnDisconnected(HSteamNetConnection connection)
- - private void OnSteamNetConnectionStatusChanged(SteamNetConnectionStatusChangedCallback_t evt)
- - private void ConnectToHost()
- - private string TryConnectSteam(LobbyEnter_t evt, bool ioFailure, out string errorTranslationKey)
- - private void OnLobbyEnter(LobbyEnter_t evt, bool ioFailure)
- - private void ConnectImplSteam()
- - private void CleanupLobbyDataRetrieve()
- - private string TryConnectGalaxy(GalaxyID lobbyId, out string errorTranslationKey)
- - private void OnLobbyDataRetrieveSuccess(GalaxyID lobbyId)
- - private void OnLobbyDataRetrieveFailure(GalaxyID lobbyId, FailureReason failureReason)
- - private void ConnectImplGalaxy()
- - private void SendMessageImpl(OutgoingMessage message)
- - private void ShutdownConnection()

## Protected Members
- - protected override string getHostUserName()
- - protected override void connectImpl()
- - protected override void receiveMessagesImpl()

## Internal Members
- *(None)*

## Other Members
- *(None)*
