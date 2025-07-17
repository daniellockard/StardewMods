# JunimoHut

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int cropHarvestRadius = 8;
- - public Chest obsolete_output;
- - public readonly NetBool noHarvest = new NetBool();
- - public readonly NetBool wasLit = new NetBool(value: false);
- - public List<JunimoHarvester> myJunimos = new List<JunimoHarvester>();
- - public Point lastKnownCropLocation = Point.Zero;
- - public NetInt raisinDays = new NetInt();
- - public NetBool shouldSendOutJunimos = new NetBool(value: false);
- - public JunimoHut(Vector2 tileLocation)
- - public JunimoHut()
- - public override Rectangle getRectForAnimalDoor(BuildingData data)
- - public override Rectangle? getSourceRectForMenu()
- - public Chest GetOutputChest()
- - public override void dayUpdate(int dayOfMonth)
- - public void sendOutJunimos()
- - public override void performActionOnConstruction(GameLocation location, Farmer who)
- - public override void resetLocalState()
- - public void updateLightState()
- - public int getUnusedJunimoNumber()
- - public override void updateWhenFarmNotCurrentLocation(GameTime time)
- - public override void Update(GameTime time)
- - public bool areThereMatureCropsWithinRadius()
- - public override void performTenMinuteAction(int timeElapsed)
- - public override bool doAction(Vector2 tileLocation, Farmer who)
- - public override void drawInMenu(SpriteBatch b, int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private int junimoSendOutTimer;
- - private Rectangle lightInteriorRect = new Rectangle(195, 0, 18, 17);
- - private Rectangle bagRect = new Rectangle(208, 51, 15, 13);
- - private Color? getGemColor(ref bool isPrismatic)

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
