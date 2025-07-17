# LocationRequest

**Summary:** Represents a place or area in the game world.

## Public Members
- - public delegate void Callback();
- - public string Name;
- - public bool IsStructure;
- - public GameLocation Location;
- - public event Callback OnLoad;
- - public event Callback OnWarp;
- - public LocationRequest(string name, bool isStructure, GameLocation location)
- - public void Loaded(GameLocation location)
- - public void Warped(GameLocation location)
- - public bool IsRequestFor(GameLocation location)
- - public override string ToString()
- - public interface IAnimalLocation

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
