# BoundingBoxGroup

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool Intersects(Rectangle rect)
- - public bool Contains(int x, int y)
- - public void Add(Rectangle rect)
- - public void ClearNonIntersecting(Rectangle rect)
- - public void Clear()
- - public void Draw(SpriteBatch b)
- - public bool IsEmpty()
- - public struct SaveablePair<TKey, TValue>
- - public TKey[] key;
- - public TValue[] value;
- - public TKey Key => key[0];
- - public TValue Value => value[0];
- - public SaveablePair(TKey key, TValue value)

## Private Members
- - private List<Rectangle> rectangles = new List<Rectangle>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
