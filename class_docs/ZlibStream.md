# ZlibStream

**Summary:** Handles data streaming or file I/O.

## Public Members
- - public virtual FlushType FlushMode
- - public int BufferSize
- - public virtual long TotalIn => _baseStream._z.TotalBytesIn;
- - public virtual long TotalOut => _baseStream._z.TotalBytesOut;
- - public override bool CanRead
- - public override bool CanSeek => false;
- - public override bool CanWrite
- - public override long Length
- - public override long Position
- - public ZlibStream(Stream stream, CompressionMode mode)
- - public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level)
- - public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen)
- - public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
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
- - private bool _disposed;

## Protected Members
- - protected override void Dispose(bool disposing)

## Internal Members
- - internal ZlibBaseStream _baseStream;

## Other Members
- *(None)*
