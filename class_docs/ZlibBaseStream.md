# ZlibBaseStream

**Summary:** Handles data streaming or file I/O.

## Public Members
- - public override bool CanRead => _stream.CanRead;
- - public override bool CanSeek => _stream.CanSeek;
- - public override bool CanWrite => _stream.CanWrite;
- - public override long Length => _stream.Length;
- - public override long Position
- - public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
- - public override void Write(byte[] buffer, int offset, int count)
- - public override void Close()
- - public override void Flush()
- - public override long Seek(long offset, SeekOrigin origin)
- - public override void SetLength(long value)
- - public override int Read(byte[] buffer, int offset, int count)
- - public static void CompressString(string s, Stream compressor)
- - public static void CompressBuffer(byte[] b, Stream compressor)
- - public static string UncompressString(byte[] compressed, Stream decompressor)
- - public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)

## Private Members
- - private CRC32 crc;
- - private bool nomoreinput;
- - private ZlibCodec z
- - private byte[] workingBuffer
- - private void finish()
- - private void end()
- - private string ReadZeroTerminatedString()
- - private int _ReadAndValidateGzipHeader()

## Protected Members
- - protected internal ZlibCodec _z;
- - protected internal StreamMode _streamMode = StreamMode.Undefined;
- - protected internal FlushType _flushMode;
- - protected internal ZlibStreamFlavor _flavor;
- - protected internal CompressionMode _compressionMode;
- - protected internal CompressionLevel _level;
- - protected internal bool _leaveOpen;
- - protected internal byte[] _workingBuffer;
- - protected internal int _bufferSize = 16384;
- - protected internal byte[] _buf1 = new byte[1];
- - protected internal Stream _stream;
- - protected internal CompressionStrategy Strategy;
- - protected internal string _GzipFileName;
- - protected internal string _GzipComment;
- - protected internal DateTime _GzipMtime;
- - protected internal int _gzipHeaderByteCount;
- - protected internal bool _wantCompress => _compressionMode == CompressionMode.Compress;

## Internal Members
- - internal enum StreamMode
- - internal int Crc32

## Other Members
- *(None)*
