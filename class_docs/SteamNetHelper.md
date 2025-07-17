# SteamNetHelper

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public SteamNetHelper()
- - public string GetUserID()
- - public Client CreateClient(object lobby)
- - public Client GetRequestedClient()
- - public Server CreateSteamServer(IGameServer gameServer)
- - public Server CreateServer(IGameServer gameServer)
- - public void AddLobbyUpdateListener(LobbyUpdateListener listener)
- - public void RemoveLobbyUpdateListener(LobbyUpdateListener listener)
- - public void RequestFriendLobbyData()
- - public string GetLobbyData(object lobby, string key)
- - public string GetLobbyOwnerName(object lobby)
- - public bool SupportsInviteCodes()
- - public object GetLobbyFromInviteCode(string inviteCode)
- - public void ShowInviteDialog(object lobby)
- - public void MutePlayer(string userId, bool mute)
- - public bool IsPlayerMuted(string userId)
- - public void ShowProfile(string userId)

## Private Members
- - private List<LobbyUpdateListener> LobbyUpdateListeners;
- - private readonly Callback<LobbyDataUpdate_t> LobbyDataUpdateCallback;
- - private readonly Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback;
- - private HybridLobby RequestedLobby;
- - private void OnGameLobbyJoinRequested(GameLobbyJoinRequested_t evt)
- - private void OnLobbyDataUpdate(LobbyDataUpdate_t evt)
- - private void FindLaunchLobby()
- - private void RequestJoinLobby(CSteamID requestedLobby)
- - private Client CreateClientFromHybrid(HybridLobby lobby)
- - private Client CreateClientHelper(HybridLobby lobby)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
