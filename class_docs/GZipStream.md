# GZipStream

**Summary:** Handles data streaming or file I/O.

## Public Members
- - public DateTime? LastModified;
- - public string Comment
- - public string FileName
- - public int Crc32 => _Crc32;
- - public virtual FlushType FlushMode
- - public int BufferSize
- - public virtual long TotalIn => _baseStream._z.TotalBytesIn;
- - public virtual long TotalOut => _baseStream._z.TotalBytesOut;
- - public override bool CanRead
- - public override bool CanSeek => false;
- - public override bool CanWrite
- - public override long Length
- - public override long Position
- - public GZipStream(Stream stream, CompressionMode mode)
- - public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
- - public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
- - public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
- - public override void Flush()
- - public override int Read(byte[] buffer, int offset, int count)
- - public override long Seek(long offset, SeekOrigin origin)
- - public override void SetLength(long value)
- - public override void Write(byte[] buffer, int offset, int count)
- - public static byte[] CompressString(string s)
- - public static byte[] CompressBuffer(byte[] b)
- - public static string UncompressString(byte[] compressed)
- - public static byte[] UncompressBuffer(byte[] compressed)

## Private Members
- - private int _headerByteCount;
- - private bool _disposed;
- - private bool _firstReadDone;
- - private string _FileName;
- - private string _Comment;
- - private int _Crc32;
- - private int EmitHeader()

## Protected Members
- - protected override void Dispose(bool disposing)

## Internal Members
- - internal ZlibBaseStream _baseStream;
- - internal static readonly DateTime _unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
- - internal static readonly Encoding iso8859dash1 = Encoding.GetEncoding("iso-8859-1");

## Other Members
- *(None)*
