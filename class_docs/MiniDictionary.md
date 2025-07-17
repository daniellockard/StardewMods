# MiniDictionary

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int HashCode;
- - public int Next;
- - public object Key;
- - public object Value;
- - public MiniDictionary()
- - public MiniDictionary(int capacity)
- - public object FindEntry(object key)
- - public void Insert(object key, object value)
- - public object GetKnownRef(object from)
- - public void AddKnownRef(object from, object to)

## Private Members
- - private struct Entry
- - private int[] _buckets;
- - private Entry[] _entries;
- - private int _count;
- - private static readonly int[] _primes = new int[72]
- - private static int GetPrime(int min)
- - private static bool IsPrime(int candidate)
- - private static int ExpandPrime(int oldSize)
- - private void Initialize(int size)
- - private void Resize()
- - private void Resize(int newSize)
- - private MiniDictionary _loops;
- - private readonly object[] _baseFromTo = new object[6];
- - private int _idx;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
