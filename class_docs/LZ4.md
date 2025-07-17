# LZ4

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static int CompressBound(int inputSize)
- - public static int CompressDefault(byte[] src, IntPtr dest, int srcSize, int dstCapacity)
- - public static int DecompressSafe(IntPtr src, byte[] dest, int compressedSize, int dstCapacity)

## Private Members
- - private static extern int lwjgl_compressBound(IntPtr env, IntPtr clazz, int inputSize);
- - private static extern int lwjgl_compress_default(IntPtr env, IntPtr clazz, byte[] src, IntPtr dest, int srcSize, int dstCapacity);
- - private static extern int lwjgl_decompress_safe(IntPtr env, IntPtr clazz, IntPtr src, byte[] dest, int compressedSize, int dstCapacity);

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
