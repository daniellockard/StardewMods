# EventContext

**Summary:** Represents a game event or cutscene.

## Public Members
- - public Event Event { get; }
- - public GameLocation Location { get; }
- - public GameTime Time { get; }
- - public string[] Args { get; }
- - public EventContext(Event @event, GameLocation location, GameTime time, string[] args)
- - public void LogError(string error, bool willSkip = false)
- - public void LogErrorAndSkip(string error, bool hideError = false)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
