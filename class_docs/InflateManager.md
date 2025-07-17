# InflateManager

**Summary:** Handles or manages a specific system or feature.

## Public Members
- - public InflateManager()
- - public InflateManager(bool expectRfc1950HeaderBytes)

## Private Members
- - private enum InflateManagerMode
- - private const int PRESET_DICT = 32;
- - private const int Z_DEFLATED = 8;
- - private InflateManagerMode mode;
- - private bool _handleRfc1950HeaderBytes = true;
- - private static readonly byte[] mark = new byte[4] { 0, 0, 255, 255 };

## Protected Members
- *(None)*

## Internal Members
- - internal ZlibCodec _codec;
- - internal int method;
- - internal uint computedCheck;
- - internal uint expectedCheck;
- - internal int marker;
- - internal int wbits;
- - internal InflateBlocks blocks;
- - internal bool HandleRfc1950HeaderBytes
- - internal int Reset()
- - internal int End()
- - internal int Initialize(ZlibCodec codec, int w)
- - internal int Inflate(FlushType flush)
- - internal int SetDictionary(byte[] dictionary)
- - internal int Sync()
- - internal int SyncPoint(ZlibCodec z)

## Other Members
- *(None)*
