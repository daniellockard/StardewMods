# GalaxyNetHelper

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public const string GalaxyConnectionStringPrefix = "-connect-lobby-";
- - public const string SteamConnectionStringPrefix = "+connect_lobby";
- - public const char GalaxyInvitePrefix = 'G';
- - public const char SteamInvitePrefix = 'S';
- - public GalaxyNetHelper()
- - public static string TryGetHostSteamDisplayName(GalaxyID lobbyId)
- - public virtual string GetUserID()
- - public Client CreateClient(object lobby)
- - public virtual Server CreateServer(IGameServer gameServer)
- - public Client GetRequestedClient()
- - public void AddLobbyUpdateListener(LobbyUpdateListener listener)
- - public void RemoveLobbyUpdateListener(LobbyUpdateListener listener)
- - public virtual void RequestFriendLobbyData()
- - public virtual string GetLobbyData(object lobby, string key)
- - public virtual string GetLobbyOwnerName(object lobbyId)
- - public bool SupportsInviteCodes()
- - public static GalaxyID GetLobbyFromGalaxyInvite(string inviteCode)
- - public object GetLobbyFromInviteCode(string inviteCode)
- - public virtual void ShowInviteDialog(object lobby)
- - public void MutePlayer(string userId, bool mute)
- - public bool IsPlayerMuted(string userId)
- - public void ShowProfile(string userId)

## Private Members
- - private GalaxyLobbyEnteredListener lobbyEntered;
- - private GalaxyGameJoinRequestedListener lobbyJoinRequested;
- - private GalaxyLobbyDataListener lobbyDataListener;
- - private GalaxyRichPresenceListener richPresenceListener;
- - private List<LobbyUpdateListener> lobbyUpdateListeners = new List<LobbyUpdateListener>();
- - private void onRichPresenceUpdated(GalaxyID userID)
- - private void onLobbyDataUpdated(GalaxyID lobbyID, GalaxyID memberID)
- - private void onLobbyJoinRequested(GalaxyID userID, string connectionString)

## Protected Members
- - protected GalaxyID lobbyRequested;
- - protected virtual Client createClient(GalaxyID lobby)
- - protected GalaxyID parseConnectionString(string connectionString)
- - protected virtual GalaxyID getStartupLobby()
- - protected virtual void onLobbyEntered(GalaxyID lobby_id, LobbyEnterResult result)

## Internal Members
- *(None)*

## Other Members
- *(None)*
