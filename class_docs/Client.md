# Client

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int connectionTimeout = 45000;
- - public bool hasHandshaked;
- - public bool readyToPlay;
- - public bool timedOut;
- - public bool connectionStarted;
- - public string serverName = "???";
- - public string connectionMessage;
- - public Multiplayer.DisconnectType pendingDisconnect;
- - public List<Farmer> availableFarmhands;
- - public Dictionary<long, string> userNames = new Dictionary<long, string>();
- - public BandwidthLogger BandwidthLogger => bandwidthLogger;
- - public bool LogBandwidth
- - public abstract void disconnect(bool neatly = true);
- - public abstract void sendMessage(OutgoingMessage message);
- - public abstract string getUserID();
- - public virtual float GetPingToHost()
- - public virtual string getUserName(long farmerId)
- - public virtual void connect()
- - public virtual void receiveMessages()
- - public virtual bool PopulatePlatformData(Farmer farmer)
- - public virtual void sendPlayerIntroduction()
- - public virtual void sendMessages()
- - public virtual void sendMessage(byte which, params object[] data)

## Private Members
- *(None)*

## Protected Members
- - protected BandwidthLogger bandwidthLogger;
- - protected long? timeoutTime;
- - protected abstract void connectImpl();
- - protected abstract void receiveMessagesImpl();
- - protected abstract string getHostUserName();
- - protected virtual void processIncomingMessage(IncomingMessage message)
- - protected virtual void receiveUserNameUpdate(BinaryReader msg)
- - protected virtual void receiveAvailableFarmhands(BinaryReader msg)
- - protected virtual void setUpGame()
- - protected virtual void receiveServerIntroduction(BinaryReader msg)

## Internal Members
- *(None)*

## Other Members
- *(None)*
