# ShippingBin

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public ShippingBin(Vector2 tileLocation)
- - public ShippingBin()
- - public void initLid()
- - public override Rectangle? getSourceRectForMenu()
- - public override void resetLocalState()
- - public override void Update(GameTime time)
- - public override void performActionOnBuildingPlacement()
- - public override bool CanLeftClick(int x, int y)
- - public override bool leftClicked()
- - public void showShipment(Item item, bool playThrowSound = true)
- - public override bool doAction(Vector2 tileLocation, Farmer who)
- - public override void drawInMenu(SpriteBatch b, int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private TemporaryAnimatedSprite shippingBinLid;
- - private Farm farm;
- - private Rectangle shippingBinLidOpenArea;
- - private void openShippingBinLid()
- - private void closeShippingBinLid()
- - private void updateShippingBinLid(GameTime time)
- - private bool isShippingBinLidOpen(bool requiredToBeFullyOpen = false)
- - private void shipItem(Item i, Farmer who)

## Protected Members
- - protected Vector2 _lidGenerationPosition;

## Internal Members
- *(None)*

## Other Members
- *(None)*
