# Server

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public abstract int connectionsCount { get; }
- - public bool LogBandwidth
- - public BandwidthLogger BandwidthLogger => bandwidthLogger;
- - public Server(IGameServer gameServer)
- - public abstract void initialize();
- - public abstract void setPrivacy(ServerPrivacy privacy);
- - public abstract void stopServer();
- - public abstract void receiveMessages();
- - public abstract void sendMessage(long peerId, OutgoingMessage message);
- - public abstract bool connected();
- - public virtual bool canAcceptIPConnections()
- - public virtual bool canOfferInvite()
- - public virtual void offerInvite()
- - public virtual string getInviteCode()
- - public virtual bool PopulatePlatformData(Farmer farmer)
- - public virtual string getUserId(long farmerId)
- - public virtual bool hasUserId(string userId)
- - public virtual float getPingToClient(long farmerId)
- - public virtual bool isConnectionActive(string connectionId)
- - public virtual void onConnect(string connectionId)
- - public virtual void onDisconnect(string connectionId)
- - public abstract string getUserName(long farmerId);
- - public abstract void setLobbyData(string key, string value);
- - public virtual void kick(long disconnectee)
- - public virtual void playerDisconnected(long disconnectee)

## Private Members
- *(None)*

## Protected Members
- - protected BandwidthLogger bandwidthLogger;

## Internal Members
- - internal IGameServer gameServer;

## Other Members
- *(None)*
