# InteriorDoorDictionary

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public struct DoorCollection : IEnumerable<InteriorDoor>, IEnumerable
- - public struct Enumerator : IEnumerator<InteriorDoor>, IEnumerator, IDisposable
- - public InteriorDoor Current => _current;
- - public Enumerator(InteriorDoorDictionary dict)
- - public bool MoveNext()
- - public void Dispose()
- - public DoorCollection(InteriorDoorDictionary dict)
- - public Enumerator GetEnumerator()
- - public DoorCollection Doors => new DoorCollection(this);
- - public InteriorDoorDictionary(GameLocation location)
- - public void ResetSharedState()
- - public void ResetLocalState()
- - public static IEnumerable<Point> GetDoorTilesFromMapProperty(GameLocation location)
- - public void MakeMapModifications()
- - public void CleanUpLocalState()
- - public void Update(GameTime time)
- - public void Draw(SpriteBatch b)

## Private Members
- - private readonly InteriorDoorDictionary _dict;
- - private Dictionary<Point, InteriorDoor>.Enumerator _enumerator;
- - private InteriorDoor _current;
- - private bool _done;
- - private InteriorDoorDictionary _dict;
- - private GameLocation location;

## Protected Members
- - protected override void setFieldValue(InteriorDoor door, Point position, bool open)

## Internal Members
- *(None)*

## Other Members
- *(None)*
