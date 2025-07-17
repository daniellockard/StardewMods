# Bimap

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public R this[L l]
- - public L this[R r]
- - public ICollection<L> LeftValues => leftToRight.Keys;
- - public ICollection<R> RightValues => rightToLeft.Keys;
- - public int Count => rightToLeft.Count;
- - public void Clear()
- - public void Add(L l, R r)
- - public bool ContainsLeft(L l)
- - public bool ContainsRight(R r)
- - public void RemoveLeft(L l)
- - public void RemoveRight(R r)
- - public L GetLeft(R r)
- - public R GetRight(L l)
- - public IEnumerator<KeyValuePair<L, R>> GetEnumerator()

## Private Members
- - private Dictionary<L, R> leftToRight = new Dictionary<L, R>();
- - private Dictionary<R, L> rightToLeft = new Dictionary<R, L>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
