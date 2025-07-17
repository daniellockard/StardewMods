# ConfirmationDialog

**Summary:** Handles in-game dialogue or conversations.

## Public Members
- - public delegate void behavior(Farmer who);
- - public const int region_okButton = 101;
- - public const int region_cancelButton = 102;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent cancelButton;
- - public ConfirmationDialog(string message, behavior onConfirm, behavior onCancel = null)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public virtual void closeDialog(Farmer who)
- - public override void snapToDefaultClickableComponent()
- - public void confirm()
- - public void cancel()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool active = true;
- - private int delayBeforeCancellable;

## Protected Members
- - protected string message;
- - protected behavior onConfirm;
- - protected behavior onCancel;

## Internal Members
- *(None)*

## Other Members
- *(None)*
