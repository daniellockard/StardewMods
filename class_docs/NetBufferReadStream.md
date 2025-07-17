# NetBufferReadStream

**Summary:** Handles data streaming or file I/O.

## Public Members
- - public NetBuffer Buffer;
- - public override bool CanRead => true;
- - public override bool CanSeek => true;
- - public override bool CanWrite => false;
- - public override long Length => (Buffer.LengthBits - offset) / 8;
- - public override long Position
- - public NetBufferReadStream(NetBuffer buffer)
- - public override void Flush()
- - public override int Read(byte[] buffer, int offset, int count)
- - public override long Seek(long offset, SeekOrigin origin)
- - public override void SetLength(long value)
- - public override void Write(byte[] buffer, int offset, int count)

## Private Members
- - private long offset;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
