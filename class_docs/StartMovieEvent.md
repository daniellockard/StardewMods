# StartMovieEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public long uid;
- - public List<List<Character>> playerGroups;
- - public List<List<Character>> npcGroups;
- - public StartMovieEvent()
- - public StartMovieEvent(long farmer_uid, List<List<Character>> player_groups, List<List<Character>> npc_groups)
- - public void Read(BinaryReader reader)
- - public void Write(BinaryWriter writer)
- - public List<List<Character>> ReadCharacterList(BinaryReader reader)
- - public void WriteCharacterList(BinaryWriter writer, List<List<Character>> group_list)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
