# TutorialMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int constructionTab = 4;
- - public const int friendshipTab = 5;
- - public const int townTab = 6;
- - public const int animalsTab = 7;
- - public TutorialMenu()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private int currentTab = -1;
- - private List<ClickableTextureComponent> topics = new List<ClickableTextureComponent>();
- - private ClickableTextureComponent backButton;
- - private ClickableTextureComponent okButton;
- - private List<ClickableTextureComponent> icons = new List<ClickableTextureComponent>();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
