# LoggingBinaryWriter

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public override Stream BaseStream => writer.BaseStream;
- - public LoggingBinaryWriter(BinaryWriter writer)
- - public void Push(string name)
- - public void Pop()
- - public override void Close()
- - public override void Flush()
- - public override long Seek(int offset, SeekOrigin origin)
- - public override void Write(short value)
- - public override void Write(ushort value)
- - public override void Write(int value)
- - public override void Write(uint value)
- - public override void Write(long value)
- - public override void Write(ulong value)
- - public override void Write(float value)
- - public override void Write(string value)
- - public override void Write(decimal value)
- - public override void Write(bool value)
- - public override void Write(byte value)
- - public override void Write(sbyte value)
- - public override void Write(byte[] buffer)
- - public override void Write(byte[] buffer, int index, int count)
- - public override void Write(char ch)
- - public override void Write(char[] chars)
- - public override void Write(char[] chars, int index, int count)
- - public override void Write(double value)

## Private Members
- - private string currentPath()

## Protected Members
- - protected BinaryWriter writer;
- - protected List<KeyValuePair<string, long>> stack = new List<KeyValuePair<string, long>>();

## Internal Members
- *(None)*

## Other Members
- *(None)*
