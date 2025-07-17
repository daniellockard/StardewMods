# SpecialOrdersBoard

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int basewidth = 338;
- - public const int baseheight = 198;
- - public ClickableComponent acceptLeftQuestButton;
- - public ClickableComponent acceptRightQuestButton;
- - public string boardType = "";
- - public SpecialOrder leftOrder;
- - public SpecialOrder rightOrder;
- - public string[] emojiIndices = new string[38]
- - public SpecialOrdersBoard(string board_type = "")
- - public virtual void UpdateButtons()
- - public override void snapToDefaultClickableComponent()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public string GetOrderType()
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)
- - public KeyValuePair<Texture2D, Rectangle>? GetPortraitForRequester(string requester_name)
- - public void DrawQuestDetails(SpriteBatch b, SpecialOrder order, int x)

## Private Members
- - private Texture2D billboardTexture;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
