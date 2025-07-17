# LanguageEntry

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly LocalizedContentManager.LanguageCode LanguageCode;
- - public readonly ModLanguage ModLanguage;
- - public readonly Texture2D Texture;
- - public readonly int SpriteIndex;
- - public LanguageEntry(LocalizedContentManager.LanguageCode languageCode, ModLanguage modLanguage, Texture2D texture, int spriteIndex)
- - public new static int width = 500;
- - public new static int height = 728;
- - public readonly Dictionary<string, LanguageEntry> languages;
- - public readonly List<ClickableComponent> languageButtons = new List<ClickableComponent>();
- - public ClickableTextureComponent nextPageButton;
- - public ClickableTextureComponent previousPageButton;
- - public LanguageSelectionMenu()
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public virtual void ApplyLanguage(LanguageEntry entry)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)

## Private Members
- - private void SetupButtons()

## Protected Members
- - protected int _currentPage;
- - protected int _pageCount;

## Internal Members
- *(None)*

## Other Members
- *(None)*
