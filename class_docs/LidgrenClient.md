# LidgrenClient

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string address;
- - public NetClient client;
- - public LidgrenClient(string address)
- - public override string getUserID()
- - public override float GetPingToHost()
- - public override void disconnect(bool neatly = true)
- - public override void sendMessage(OutgoingMessage message)

## Private Members
- - private bool serverDiscovered;
- - private int maxRetryAttempts;
- - private int retryMs = 10000;
- - private double lastAttemptMs;
- - private int retryAttempts;
- - private float lastLatencyMs;
- - private void attemptConnection()
- - private void readLatency(NetIncomingMessage msg)
- - private void receiveHandshake(NetIncomingMessage msg)
- - private void statusChanged(NetIncomingMessage message)
- - private void clientRemotelyDisconnected(NetConnectionStatus status, string message)
- - private void parseDataMessageFromServer(NetIncomingMessage dataMsg)

## Protected Members
- - protected override string getHostUserName()
- - protected override void connectImpl()
- - protected virtual bool validateProtocol(string version)
- - protected override void receiveMessagesImpl()
- - protected virtual void sendMessageImpl(OutgoingMessage message)

## Internal Members
- *(None)*

## Other Members
- *(None)*
