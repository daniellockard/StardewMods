# PriorityQueue

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public PriorityQueue()
- - public bool IsEmpty()
- - public void Clear()
- - public bool Contains(PathNode p, int priority)
- - public PathNode Dequeue()
- - public object Peek()
- - public object Dequeue(int priority)
- - public void Enqueue(PathNode item, int priority)

## Private Members
- - private int total_size;
- - private SortedDictionary<int, Queue<PathNode>> nodes;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
