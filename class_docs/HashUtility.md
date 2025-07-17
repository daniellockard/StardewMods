# HashUtility

**Summary:** Utility or helper class.

## Public Members
- - public int GetDeterministicHashCode(string value)
- - public int GetDeterministicHashCode(params int[] values)
- - public int GetDeterministicHashCode(byte[] data)
- - public interface IHashUtility

## Private Members
- - private static readonly IHashFunction Hasher = (IHashFunction)new xxHash(32);

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
