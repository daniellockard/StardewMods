# EventRecording

**Summary:** Represents a game event or cutscene.

## Public Members
- - public T arg;
- - public uint timestamp;
- - public EventRecording(T arg, uint timestamp)
- - public delegate void Event(T arg);
- - public bool InterpolationWait = true;
- - public event Event onEvent;
- - public bool HasPendingEvent(Predicate<T> match)
- - public void Clear()
- - public void Fire(T arg)
- - public void Poll()
- - public override void Read(BinaryReader reader, NetVersion version)
- - public override void ReadFull(BinaryReader reader, NetVersion version)
- - public override void Write(BinaryWriter writer)
- - public override void WriteFull(BinaryWriter writer)

## Private Members
- - private List<EventRecording> outgoingEvents = new List<EventRecording>();
- - private List<EventRecording> incomingEvents = new List<EventRecording>();

## Protected Members
- - protected abstract T readEventArg(BinaryReader reader, NetVersion version);
- - protected abstract void writeEventArg(BinaryWriter writer, T arg);
- - protected override void CleanImpl()

## Internal Members
- *(None)*

## Other Members
- *(None)*
