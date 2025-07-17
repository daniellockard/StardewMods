# ZlibCodec

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public byte[] InputBuffer;
- - public int NextIn;
- - public int AvailableBytesIn;
- - public long TotalBytesIn;
- - public byte[] OutputBuffer;
- - public int NextOut;
- - public int AvailableBytesOut;
- - public long TotalBytesOut;
- - public string Message;
- - public CompressionLevel CompressLevel = CompressionLevel.Default;
- - public int WindowBits = 15;
- - public CompressionStrategy Strategy;
- - public int Adler32 => (int)_Adler32;
- - public ZlibCodec()
- - public ZlibCodec(CompressionMode mode)
- - public int InitializeInflate()
- - public int InitializeInflate(bool expectRfc1950Header)
- - public int InitializeInflate(int windowBits)
- - public int InitializeInflate(int windowBits, bool expectRfc1950Header)
- - public int Inflate(FlushType flush)
- - public int EndInflate()
- - public int SyncInflate()
- - public int InitializeDeflate()
- - public int InitializeDeflate(CompressionLevel level)
- - public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
- - public int InitializeDeflate(CompressionLevel level, int bits)
- - public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
- - public int Deflate(FlushType flush)
- - public int EndDeflate()
- - public void ResetDeflate()
- - public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
- - public int SetDictionary(byte[] dictionary)

## Private Members
- - private int _InternalInitializeDeflate(bool wantRfc1950Header)

## Protected Members
- *(None)*

## Internal Members
- - internal DeflateManager dstate;
- - internal InflateManager istate;
- - internal uint _Adler32;
- - internal void flush_pending()
- - internal int read_buf(byte[] buf, int start, int size)

## Other Members
- *(None)*
