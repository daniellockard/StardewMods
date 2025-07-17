# MovieTheaterScreeningEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public int currentResponse;
- - public List<List<Character>> playerAndGuestAudienceGroups;
- - public Dictionary<int, Character> _responseOrder = new Dictionary<int, Character>();
- - public MovieData movieData;
- - public Event getMovieEvent(string movieId, List<List<Character>> player_and_guest_audience_groups, List<List<Character>> npcOnlyAudienceGroups, Dictionary<Character, MovieConcession> concessions_data = null)
- - public Dictionary<Character, string> GetCharacterResponses()

## Private Members
- - private static string getEventName(Character c)
- - private Point getBackRowSeatTileFromIndex(int index)
- - private Point getMidRowSeatTileFromIndex(int index)
- - private Point getFrontRowSeatTileFromIndex(int index)

## Protected Members
- - protected Dictionary<Character, Character> _whiteListDependencyLookup;
- - protected Dictionary<Character, string> _characterResponses;
- - protected List<Farmer> _farmers;
- - protected Dictionary<Character, MovieConcession> _concessionsData;
- - protected void _ParseScene(StringBuilder sb, MovieScene scene)
- - protected void _ParseResponse(StringBuilder sb, MovieScene scene = null)
- - protected void _ParseCharacterResponse(StringBuilder sb, Character responding_character, bool ignoreScript = false)

## Internal Members
- *(None)*

## Other Members
- *(None)*
