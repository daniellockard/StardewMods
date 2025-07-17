# CrcCalculatorStream

**Summary:** Handles data streaming or file I/O.

## Public Members
- - public long TotalBytesSlurped => _Crc32.TotalBytesRead;
- - public int Crc => _Crc32.Crc32Result;
- - public bool LeaveOpen
- - public override bool CanRead => _innerStream.CanRead;
- - public override bool CanSeek => false;
- - public override bool CanWrite => _innerStream.CanWrite;
- - public override long Length
- - public override long Position
- - public CrcCalculatorStream(Stream stream)
- - public CrcCalculatorStream(Stream stream, bool leaveOpen)
- - public CrcCalculatorStream(Stream stream, long length)
- - public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
- - public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
- - public override int Read(byte[] buffer, int offset, int count)
- - public override void Write(byte[] buffer, int offset, int count)
- - public override void Flush()
- - public override long Seek(long offset, SeekOrigin origin)
- - public override void SetLength(long value)
- - public override void Close()

## Private Members
- - private static readonly long UnsetLengthLimit = -99L;
- - private CRC32 _Crc32;
- - private long _lengthLimit = -99L;
- - private bool _leaveOpen;
- - private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)

## Protected Members
- *(None)*

## Internal Members
- - internal Stream _innerStream;

## Other Members
- *(None)*
