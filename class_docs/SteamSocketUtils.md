# SteamSocketUtils

**Summary:** Utility or helper class.

## Public Members
- *(None)*

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- - internal static SteamNetworkingConfigValue_t[] GetNetworkingOptions()
- - internal static void ProcessSteamMessage(IntPtr messagePtr, IncomingMessage message, out HSteamNetConnection messageConnection, BandwidthLogger bandwidthLogger)
- - internal unsafe static void SendMessage(HSteamNetConnection messageConnection, OutgoingMessage message, BandwidthLogger bandwidthLogger, Action<HSteamNetConnection> onDisconnected = null)
- - internal static void CloseConnection(HSteamNetConnection connection, Action<HSteamNetConnection> onDisconnected = null)

## Other Members
- *(None)*
