# NetBufferWriteStream

**Summary:** Handles data streaming or file I/O.

## Public Members
- - public NetBuffer Buffer;
- - public override bool CanRead => false;
- - public override bool CanSeek => true;
- - public override bool CanWrite => true;
- - public override long Length
- - public override long Position
- - public NetBufferWriteStream(NetBuffer buffer)
- - public override void Flush()
- - public override int Read(byte[] buffer, int offset, int count)
- - public override long Seek(long offset, SeekOrigin origin)
- - public override void SetLength(long value)
- - public override void Write(byte[] buffer, int offset, int count)

## Private Members
- - private int offset;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
