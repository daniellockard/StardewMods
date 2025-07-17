# CRC32

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public long TotalBytesRead => _TotalBytesRead;
- - public int Crc32Result => (int)(~_register);
- - public int GetCrc32(Stream input)
- - public int GetCrc32AndCopy(Stream input, Stream output)
- - public int ComputeCrc32(int W, byte B)
- - public void SlurpBlock(byte[] block, int offset, int count)
- - public void UpdateCRC(byte b)
- - public void UpdateCRC(byte b, int n)
- - public void Combine(int crc, int length)
- - public CRC32()
- - public CRC32(bool reverseBits)
- - public CRC32(int polynomial, bool reverseBits)
- - public void Reset()

## Private Members
- - private uint dwPolynomial;
- - private long _TotalBytesRead;
- - private bool reverseBits;
- - private uint[] crc32Table;
- - private const int BUFFER_SIZE = 8192;
- - private uint _register = uint.MaxValue;
- - private static uint ReverseBits(uint data)
- - private static byte ReverseBits(byte data)
- - private void GenerateLookupTable()
- - private uint gf2_matrix_times(uint[] matrix, uint vec)
- - private void gf2_matrix_square(uint[] square, uint[] mat)

## Protected Members
- *(None)*

## Internal Members
- - internal int _InternalComputeCrc32(uint W, byte B)

## Other Members
- *(None)*
