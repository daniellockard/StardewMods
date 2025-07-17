# LidgrenServer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int defaultPort = 24642;
- - public NetServer server;
- - public override int connectionsCount
- - public LidgrenServer(IGameServer gameServer)
- - public override bool isConnectionActive(string connectionID)
- - public override string getUserId(long farmerId)
- - public override bool hasUserId(string userId)
- - public override string getUserName(long farmerId)
- - public override float getPingToClient(long farmerId)
- - public override void setPrivacy(ServerPrivacy privacy)
- - public override bool canAcceptIPConnections()
- - public override bool connected()
- - public override void initialize()
- - public override void stopServer()
- - public static bool IsLocal(string host_name_or_address)
- - public override void receiveMessages()
- - public override void kick(long disconnectee)
- - public override void playerDisconnected(long disconnectee)
- - public string getConnectionId(NetConnection connection)
- - public override void sendMessage(long peerId, OutgoingMessage message)
- - public override void setLobbyData(string key, string value)

## Private Members
- - private HashSet<NetConnection> introductionsSent = new HashSet<NetConnection>();
- - private void sendVersionInfo(NetIncomingMessage message)
- - private void statusChanged(NetIncomingMessage message)

## Protected Members
- - protected Bimap<long, NetConnection> peers = new Bimap<long, NetConnection>();
- - protected virtual void parseDataMessageFromClient(NetIncomingMessage dataMsg)
- - protected virtual void sendMessage(NetConnection connection, OutgoingMessage message)

## Internal Members
- *(None)*

## Other Members
- *(None)*
