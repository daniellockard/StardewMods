# NetLeaderboards

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public NetObjectList<NetLeaderboardsEntry> entries = new NetObjectList<NetLeaderboardsEntry>();
- - public NetInt maxEntries = new NetInt(10);
- - public NetFields NetFields { get; } = new NetFields("NetLeaderboards");
- - public void InitNetFields()
- - public NetLeaderboards()
- - public void AddScore(string name, int score)
- - public List<KeyValuePair<string, int>> GetScores()
- - public void LoadScores(List<KeyValuePair<string, int>> scores)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
