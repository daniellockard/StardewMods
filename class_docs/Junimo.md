# Junimo

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetInt whichArea = new NetInt();
- - public readonly NetBool friendly = new NetBool();
- - public readonly NetBool holdingStar = new NetBool();
- - public readonly NetBool holdingBundle = new NetBool();
- - public readonly NetBool temporaryJunimo = new NetBool();
- - public readonly NetBool stayPut = new NetBool();
- - public override bool IsVillager => false;
- - public Junimo()
- - public Junimo(Vector2 position, int whichArea, bool temporary = false)
- - public override bool canPassThroughActionTiles()
- - public override bool shouldCollideWithBuildingLayer(GameLocation location)
- - public override bool canTalk()
- - public override void ChooseAppearance(LocalizedContentManager content = null)
- - public void fadeAway()
- - public void setAlpha(float a)
- - public void fadeBack()
- - public void setMoving(int xSpeed, int ySpeed)
- - public void setMoving(Vector2 motion)
- - public override void Halt()
- - public void returnToJunimoHut(GameLocation location)
- - public void stayStill()
- - public void allowToMoveAgain()
- - public void returnToJunimoHutToFetchStar(GameLocation location)
- - public void bringBundleBackToHut(Color bundleColor, GameLocation location)
- - public void sayGoodbye()
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public void junimoReachedHut(Character c, GameLocation l)
- - public override void update(GameTime time, GameLocation location)
- - public override void draw(SpriteBatch b, float alpha = 1f)
- - public override void DrawShadow(SpriteBatch b)

## Private Members
- - private readonly NetFloat alpha = new NetFloat(1f);
- - private readonly NetFloat alphaChange = new NetFloat();
- - private readonly NetVector2 motion = new NetVector2(Vector2.Zero);
- - private new readonly NetRectangle nextPosition = new NetRectangle();
- - private readonly NetColor color = new NetColor();
- - private readonly NetColor bundleColor = new NetColor();
- - private readonly NetBool sayingGoodbye = new NetBool();
- - private readonly NetEvent0 setReturnToJunimoHutToFetchStarControllerEvent = new NetEvent0();
- - private readonly NetEvent0 setBringBundleBackToHutControllerEvent = new NetEvent0();
- - private readonly NetEvent0 setJunimoReachedHutToFetchStarControllerEvent = new NetEvent0();
- - private readonly NetEvent0 starDoneSpinningEvent = new NetEvent0();
- - private readonly NetEvent0 returnToJunimoHutToFetchFinalStarEvent = new NetEvent0();
- - private int farmerCloseCheckTimer = 100;
- - private static int soundTimer;
- - private void returnToJunimoHutToFetchFinalStar()
- - private void setReturnToJunimoHutToFetchStarController()
- - private void finalCutscene()
- - private void setBringBundleBackToHutController()
- - private void junimoReachedHutToReturnBundle(Character c, GameLocation l)
- - private void junimoReachedHutToFetchStar(Character c, GameLocation l)
- - private void setJunimoReachedHutToFetchStarController()
- - private void placeStar(Character c, GameLocation l)
- - private void goodbyeDance()
- - private void starDoneSpinning(int extraInfo)
- - private void performStartDoneSpinning()

## Protected Members
- - protected override void initNetFields()
- - protected override void updateSlaveAnimation(GameTime time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
