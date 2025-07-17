# GalaxyNetClient

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public GalaxyID lobbyId;
- - public GalaxyNetClient(GalaxyID lobbyId)
- - public override string getUserID()
- - public override float GetPingToHost()
- - public override void disconnect(bool neatly = true)
- - public override void sendMessage(OutgoingMessage message)

## Private Members
- - private GalaxyID serverId;
- - private string hostDisplayName;
- - private GalaxySpecificUserDataListener galaxySpecificUserDataListener;
- - private float lastPingMs;
- - private void onProfileDataReady(GalaxyID userID)

## Protected Members
- - protected GalaxySocket client;
- - protected override string getHostUserName()
- - protected override void connectImpl()
- - protected override void receiveMessagesImpl()
- - protected virtual void onReceiveConnection(GalaxyID peer)
- - protected virtual void onReceiveMessage(GalaxyID peer, Stream messageStream)
- - protected virtual void onReceiveDisconnect(GalaxyID peer)
- - protected virtual void onReceiveError(string message)
- - protected virtual void sendMessageImpl(OutgoingMessage message)

## Internal Members
- *(None)*

## Other Members
- *(None)*
