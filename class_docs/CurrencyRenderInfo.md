# CurrencyRenderInfo

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public CurrencyDisplayType currency;
- - public MoneyDial moneyDial = new MoneyDial(3)
- - public float slidePosition;
- - public Func<bool> keepOpen;
- - public float timeToLive;
- - public CurrencyRenderInfo(CurrencyDisplayType currency, Func<bool> keepOpen = null, float timeToLive = 5f)
- - public void OnCurrencyChanged(int oldValue, int newValue)
- - public const string currency_walnuts = "walnuts";
- - public const string currency_qiGems = "qiGems";
- - public const int defaultSeconds = 5;
- - public Dictionary<string, CurrencyDisplayType> registeredCurrencyDisplays = new Dictionary<string, CurrencyDisplayType>();
- - public readonly List<CurrencyRenderInfo> displayedCurrencies = new List<CurrencyRenderInfo>();
- - public virtual void Register(string key, NetIntDelta field, Action<int> playSound = null, Action<SpriteBatch, Vector2> drawIcon = null)
- - public virtual void ShowCurrency(string currency, Func<bool> keepOpen = null, float timeToLive = 5f)
- - public virtual void HideCurrency(string currency, bool immediate = true)
- - public virtual void OnCurrencyChange(NetIntDelta field, int oldValue, int newValue)
- - public virtual void Unregister(string key)
- - public virtual void Cleanup()
- - public virtual void DrawIcon(string currency, SpriteBatch b, Vector2 position)
- - public virtual void PlaySound(string currency, int direction)
- - public virtual void Update(GameTime time)
- - public Vector2 GetUpperLeft(float slidePosition)
- - public virtual void Draw(SpriteBatch b)
- - public static void Draw(SpriteBatch b, Vector2 drawPosition, MoneyDial moneyDial, int displayedValue, Texture2D drawSpriteTexture, Rectangle drawSpriteSourceRect)
- - public static void Draw(SpriteBatch b, Vector2 drawPosition, int displayedValue, Texture2D drawSpriteTexture, Rectangle drawSpriteSourceRect)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
