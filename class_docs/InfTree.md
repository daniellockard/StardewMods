# InfTree

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- *(None)*

## Private Members
- - private const int MANY = 1440;
- - private const int Z_OK = 0;
- - private const int Z_STREAM_END = 1;
- - private const int Z_NEED_DICT = 2;
- - private const int Z_ERRNO = -1;
- - private const int Z_STREAM_ERROR = -2;
- - private const int Z_DATA_ERROR = -3;
- - private const int Z_MEM_ERROR = -4;
- - private const int Z_BUF_ERROR = -5;
- - private const int Z_VERSION_ERROR = -6;
- - private int huft_build(int[] b, int bindex, int n, int s, int[] d, int[] e, int[] t, int[] m, int[] hp, int[] hn, int[] v)
- - private void initWorkArea(int vsize)

## Protected Members
- *(None)*

## Internal Members
- - internal const int fixed_bl = 9;
- - internal const int fixed_bd = 5;
- - internal static readonly int[] fixed_tl = new int[1536]
- - internal static readonly int[] fixed_td = new int[96]
- - internal static readonly int[] cplens = new int[31]
- - internal static readonly int[] cplext = new int[31]
- - internal static readonly int[] cpdist = new int[30]
- - internal static readonly int[] cpdext = new int[30]
- - internal const int BMAX = 15;
- - internal int[] hn;
- - internal int[] v;
- - internal int[] c;
- - internal int[] r;
- - internal int[] u;
- - internal int[] x;
- - internal int inflate_trees_bits(int[] c, int[] bb, int[] tb, int[] hp, ZlibCodec z)
- - internal int inflate_trees_dynamic(int nl, int nd, int[] c, int[] bl, int[] bd, int[] tl, int[] td, int[] hp, ZlibCodec z)
- - internal static int inflate_trees_fixed(int[] bl, int[] bd, int[][] tl, int[][] td, ZlibCodec z)

## Other Members
- *(None)*
