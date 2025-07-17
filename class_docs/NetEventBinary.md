# NetEventBinary

**Summary:** Represents a game event or cutscene.

## Public Members
- - public delegate void ArgWriter(BinaryWriter writer);
- - public void Fire(ArgWriter argWriter)
- - public void AddReaderHandler(Action<BinaryReader> handler)
- - public interface NetEventArg

## Private Members
- *(None)*

## Protected Members
- - protected override byte[] readEventArg(BinaryReader reader, NetVersion version)
- - protected override void writeEventArg(BinaryWriter writer, byte[] arg)

## Internal Members
- *(None)*

## Other Members
- *(None)*
