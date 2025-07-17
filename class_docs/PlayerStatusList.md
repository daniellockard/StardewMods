# PlayerStatusList

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum SortMode
- - public enum DisplayMode
- - public enum VerticalAlignment
- - public enum HorizontalAlignment
- - public int iconAnimationFrames = 1;
- - public int largestSpriteWidth;
- - public int largestSpriteHeight;
- - public SortMode sortMode;
- - public DisplayMode displayMode;
- - public NetFields NetFields { get; } = new NetFields("PlayerStatusList");
- - public PlayerStatusList()
- - public void InitNetFields()
- - public void AddSpriteDefinition(string key, string file, int x, int y, int width, int height)
- - public void UpdateState(string newState)
- - public void WithdrawState()
- - public bool TryGetStatusText(long id, out string statusText)
- - public string GetStatusText(long id, string fallback = "")
- - public int GetStatusInt(long id, int fallback = 0)
- - public void Draw(SpriteBatch b, Vector2 draw_position, float draw_scale = 4f, float draw_layer = 0.45f, HorizontalAlignment horizontal_origin = HorizontalAlignment.Left, VerticalAlignment vertical_origin = VerticalAlignment.Top)

## Private Members
- *(None)*

## Protected Members
- - protected readonly NetLongDictionary<string, NetString> _statusList = new NetLongDictionary<string, NetString>
- - protected readonly Dictionary<long, string> _formattedStatusList = new Dictionary<long, string>();
- - protected readonly Dictionary<string, Texture2D> _iconSprites = new Dictionary<string, Texture2D>();
- - protected readonly List<Farmer> _sortedFarmers = new List<Farmer>();
- - protected Dictionary<string, KeyValuePair<string, Rectangle>> _iconDefinitions = new Dictionary<string, KeyValuePair<string, Rectangle>>();
- - protected void _OnValueChanged()
- - protected void _ResortList()

## Internal Members
- *(None)*

## Other Members
- *(None)*
