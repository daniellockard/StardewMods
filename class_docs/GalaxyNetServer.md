# GalaxyNetServer

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public override int connectionsCount
- - public GalaxyNetServer(IGameServer gameServer)
- - public override string getUserId(long farmerId)
- - public override bool hasUserId(string userId)
- - public override bool isConnectionActive(string connection_id)
- - public override string getUserName(long farmerId)
- - public override float getPingToClient(long farmerId)
- - public override void setPrivacy(ServerPrivacy privacy)
- - public override bool connected()
- - public override string getInviteCode()
- - public override void initialize()
- - public override void stopServer()
- - public override void receiveMessages()
- - public override void kick(long disconnectee)
- - public string getConnectionId(GalaxyID peer)
- - public virtual void onReceiveDisconnect(GalaxyID peer)
- - public override void playerDisconnected(long disconnectee)
- - public override void sendMessage(long peerId, OutgoingMessage message)
- - public override void setLobbyData(string key, string value)

## Private Members
- - private GalaxyID host;
- - private GalaxySpecificUserDataListener galaxySpecificUserDataListener;
- - private void onProfileDataReady(GalaxyID userID)
- - private string createUserID(GalaxyID peer)

## Protected Members
- - protected GalaxySocket server;
- - protected Bimap<long, ulong> peers = new Bimap<long, ulong>();
- - protected Dictionary<ulong, string> displayNames = new Dictionary<ulong, string>();
- - protected virtual void onReceiveConnection(GalaxyID peer)
- - protected virtual void onReceiveMessage(GalaxyID peer, Stream messageStream)
- - protected virtual void onReceiveError(string messageKey)
- - protected virtual void sendMessage(GalaxyID peer, OutgoingMessage message)

## Internal Members
- *(None)*

## Other Members
- *(None)*
