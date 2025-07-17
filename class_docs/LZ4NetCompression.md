# LZ4NetCompression

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public byte[] CompressAbove(byte[] data, int minSizeToCompress = 256)
- - public byte[] DecompressBytes(byte[] data)
- - public bool TryDecompressStream(Stream dataStream, out byte[] decompressed)

## Private Members
- - private const int HeaderSize = 9;
- - private unsafe byte[] DecompressImpl(byte[] data)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
