# ConnectionData

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public long FarmerId = long.MinValue;
- - public CSteamID SteamId;
- - public HSteamNetConnection Connection;
- - public bool Online;
- - public string DisplayName;
- - public ConnectionData(HSteamNetConnection connection, CSteamID steamId, string displayName)
- - public ulong SteamId { get; private set; }
- - public ulong GalaxyId { get; private set; }
- - public LobbyConnectionType LobbyType
- - public HybridLobby(CSteamID steamID)
- - public HybridLobby(GalaxyID galaxyID, bool isHybrid = false)
- - public void Clear()

## Private Members
- - private bool IsHybrid;

## Protected Members
- *(None)*

## Internal Members
- - internal struct HybridLobby
- - internal enum LobbyConnectionType

## Other Members
- *(None)*
