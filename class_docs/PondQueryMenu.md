# PondQueryMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public const int region_okButton = 101;
- - public const int region_emptyButton = 103;
- - public const int region_noButton = 105;
- - public const int region_nettingButton = 106;
- - public new static int width = 384;
- - public new static int height = 512;
- - public const int unresolved_needs_extra_height = 116;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent emptyButton;
- - public ClickableTextureComponent yesButton;
- - public ClickableTextureComponent noButton;
- - public ClickableTextureComponent changeNettingButton;
- - public PondQueryMenu(FishPond fish_pond)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override bool readyToClose()
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public static string GetFishTalkSuffix(Object fishItem)
- - public static string getCompletedRequestString(FishPond pond, Object fishItem, Random r)
- - public void UpdateState()
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool confirmingEmpty;
- - private string hoverText = "";
- - private int measureTotalHeight()
- - private int measureExtraTextHeight(string displayed_text)
- - private string getDisplayedText()

## Protected Members
- - protected FishPond _pond;
- - protected Object _fishItem;
- - protected string _statusText = "";
- - protected Rectangle _confirmationBoxRectangle;
- - protected string _confirmationText;
- - protected float _age;

## Internal Members
- *(None)*

## Other Members
- *(None)*
