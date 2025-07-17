# InflateBlocks

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- *(None)*

## Private Members
- - private enum InflateBlockMode
- - private const int MANY = 1440;
- - private InflateBlockMode mode;

## Protected Members
- *(None)*

## Internal Members
- - internal static readonly int[] border = new int[19]
- - internal int left;
- - internal int table;
- - internal int index;
- - internal int[] blens;
- - internal int[] bb = new int[1];
- - internal int[] tb = new int[1];
- - internal InflateCodes codes = new InflateCodes();
- - internal int last;
- - internal ZlibCodec _codec;
- - internal int bitk;
- - internal int bitb;
- - internal int[] hufts;
- - internal byte[] window;
- - internal int end;
- - internal int readAt;
- - internal int writeAt;
- - internal object checkfn;
- - internal uint check;
- - internal InfTree inftree = new InfTree();
- - internal InflateBlocks(ZlibCodec codec, object checkfn, int w)
- - internal uint Reset()
- - internal int Process(int r)
- - internal void Free()
- - internal void SetDictionary(byte[] d, int start, int n)
- - internal int SyncPoint()
- - internal int Flush(int r)

## Other Members
- *(None)*
