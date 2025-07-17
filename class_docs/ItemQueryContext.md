# ItemQueryContext

**Summary:** Represents an item in the game, such as tools, crops, or inventory objects.

## Public Members
- - public GameLocation Location { get; }
- - public Farmer Player { get; }
- - public Random Random { get; }
- - public string QueryString { get; internal set; }
- - public ItemQueryContext ParentContext { get; }
- - public string SourcePhrase { get; set; }
- - public Dictionary<string, object> CustomFields { get; set; }
- - public ItemQueryContext()
- - public ItemQueryContext(ItemQueryContext parentContext, string sourceLabel = null)
- - public ItemQueryContext(GameLocation location, Farmer player, Random random, string sourcePhrase)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
