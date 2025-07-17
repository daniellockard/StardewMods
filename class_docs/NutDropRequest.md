# NutDropRequest

**Summary:** Represents a quest or mission.

## Public Members
- - public string Key { get; private set; }
- - public string LocationName { get; private set; }
- - public Point Tile { get; private set; }
- - public int Limit { get; private set; } = 1;
- - public int RewardAmount { get; private set; } = 1;
- - public NutDropRequest()
- - public NutDropRequest(string key, string locationName, Point tile, int limit, int rewardAmount)
- - public void Read(BinaryReader reader)
- - public void Write(BinaryWriter writer)
- - public enum PlayerActionTarget : byte

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
