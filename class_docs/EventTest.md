# EventTest

**Summary:** Represents a game event or cutscene.

## Public Members
- - public EventTest(string startingLocationName = "", int startingEventIndex = 0)
- - public EventTest(string[] whichEvents)
- - public void update()

## Private Members
- - private int currentEventIndex;
- - private int currentLocationIndex;
- - private int aButtonTimer;
- - private List<string> specificEventsToDo = new List<string>();
- - private bool doingSpecifics;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
