# EmoteSelector

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Rectangle scrollView;
- - public List<ClickableTextureComponent> emoteButtons;
- - public ClickableTextureComponent okButton;
- - public float scrollY;
- - public int emoteIndex;
- - public EmoteSelector(int emote_index, string selected_emote = "")
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void performHoverAction(int x, int y)
- - public void RepositionScrollElements()
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public bool canLeaveMenu()
- - public override void draw(SpriteBatch b)

## Private Members
- - private void RepositionElements()

## Protected Members
- - protected ClickableTextureComponent _selectedEmote;
- - protected ClickableTextureComponent _hoveredEmote;
- - protected Texture2D emoteTexture;
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
