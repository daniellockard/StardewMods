# BeachNightMarket

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public BeachNightMarket()
- - public BeachNightMarket(string mapPath, string name)
- - public override void DayUpdate(int dayOfMonth)
- - public override void draw(SpriteBatch b)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public int getDayOfNightMarket()
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public void getFreeGiftPartOne(int extra)
- - public void getFreeGift(int extra)
- - public override void MakeMapModifications(bool force = false)
- - public override void performTenMinuteUpdate(int timeOfDay)
- - public override void UpdateWhenCurrentLocation(GameTime time)

## Private Members
- - private Texture2D shopClosedTexture;
- - private float smokeTimer;
- - private string paintingMailKey;
- - private bool hasReceivedFreeGift;
- - private bool hasShownCCUpgrade;

## Protected Members
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
