# AnimationPreviewTool

**Summary:** Represents a tool used by the player (hoe, axe, etc.).

## Public Members
- - public List<List<ClickableTextureComponent>> components;
- - public Rectangle scrollView;
- - public List<ClickableTextureComponent> animationButtons;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent hairLabel;
- - public ClickableTextureComponent shirtLabel;
- - public ClickableTextureComponent pantsLabel;
- - public float scrollY;
- - public AnimationPreviewTool()
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public void SwitchShirt(int direction)
- - public void SwitchHair(int direction)
- - public void SwitchPants(int direction)
- - public void UpdateLabels()
- - public void RepositionScrollElements()
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void receiveKeyPress(Keys key)
- - public override void receiveScrollWheelAction(int direction)
- - public override void performHoverAction(int x, int y)
- - public bool canLeaveMenu()
- - public override void draw(SpriteBatch b)

## Private Members
- - private void RepositionElements()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
