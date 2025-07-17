# FieldOfficeMenu

**Summary:** Represents a UI menu or screen.

## Public Members
- - public List<ClickableComponent> pieceHolders = new List<ClickableComponent>();
- - public FieldOfficeMenu(IslandFieldOffice office)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public override void snapToDefaultClickableComponent()
- - public static bool highlightBones(Item i)
- - public static int getPieceIndexForDonationItem(string qualifiedItemId)
- - public static int getDonationPieceIndexNeededForSpot(int donationSpotIndex)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public void checkForSetFinish()
- - public override void update(GameTime time)
- - public override void draw(SpriteBatch b)

## Private Members
- - private Texture2D fieldOfficeMenuTexture;
- - private IslandFieldOffice office;
- - private bool madeADonation;
- - private bool gotReward;
- - private float bearTimer;
- - private float snakeTimer;
- - private float batTimer;
- - private float frogTimer;
- - private bool donate(int index, int x, int y)
- - private void drawHighlightedSquare(int index, SpriteBatch b)

## Protected Members
- - protected override void cleanupBeforeExit()

## Internal Members
- *(None)*

## Other Members
- *(None)*
