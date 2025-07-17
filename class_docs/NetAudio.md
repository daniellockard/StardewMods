# NetAudio

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetFields NetFields { get; } = new NetFields("NetAudio");
- - public NetDictionary<string, bool, NetBool, SerializableDictionary<string, bool>, NetStringDictionary<bool, NetBool>>.KeysCollection ActiveCues => activeCues.Keys;
- - public NetAudio(GameLocation location)
- - public void Update()
- - public void Fire(string audioName, Vector2? position, int? pitch, SoundContext context)
- - public void Read(BinaryReader reader, out string audioName, out Vector2? position, out int? pitch, out SoundContext context)
- - public void StartPlaying(string cueName)
- - public void StopPlaying(string cueName)

## Private Members
- - private readonly NetEventBinary audioEvent = new NetEventBinary();
- - private readonly NetStringDictionary<bool, NetBool> activeCues = new NetStringDictionary<bool, NetBool>();
- - private GameLocation location;
- - private void handleAudioEvent(BinaryReader reader)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
