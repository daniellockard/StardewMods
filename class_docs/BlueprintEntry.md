# BlueprintEntry

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int Index { get; }
- - public string Id { get; }
- - public BuildingData Data { get; }
- - public BuildingSkin Skin { get; private set; }
- - public string DisplayName { get; private set; }
- - public string DisplayNameForGeneralType { get; private set; }
- - public string TokenizedDisplayName { get; private set; }
- - public string TokenizedDisplayNameForGeneralType { get; private set; }
- - public string Description { get; private set; }
- - public int TilesWide { get; }
- - public int TilesHigh { get; }
- - public bool IsUpgrade
- - public int BuildDays => Skin?.BuildDays ?? Data.BuildDays;
- - public int BuildCost => Skin?.BuildCost ?? Data.BuildCost;
- - public List<BuildingMaterial> BuildMaterials => Skin?.BuildMaterials ?? Data.BuildMaterials;
- - public string UpgradeFrom => Data.BuildingToUpgrade;
- - public bool MagicalConstruction => Data.MagicalConstruction;
- - public BlueprintEntry(int index, string id, BuildingData data, string skinId)
- - public void SetSkin(string id)
- - public string GetDisplayNameForBuildingToUpgrade()
- - public const int region_backButton = 101;
- - public const int region_forwardButton = 102;
- - public const int region_upgradeIcon = 103;
- - public const int region_demolishButton = 104;
- - public const int region_moveBuitton = 105;
- - public const int region_okButton = 106;
- - public const int region_cancelButton = 107;
- - public const int region_paintButton = 108;
- - public const int region_appearanceButton = 109;
- - public int maxWidthOfBuildingViewer = 448;
- - public int maxHeightOfBuildingViewer = 512;
- - public int maxWidthOfDescription = 416;
- - public readonly string Builder;
- - public readonly string BuilderLocationName;
- - public readonly Location BuilderViewport;
- - public GameLocation TargetLocation;
- - public Vector2? TargetViewportCenterOnTile;
- - public readonly List<BlueprintEntry> Blueprints = new List<BlueprintEntry>();
- - public BlueprintEntry Blueprint;
- - public ClickableTextureComponent okButton;
- - public ClickableTextureComponent cancelButton;
- - public ClickableTextureComponent backButton;
- - public ClickableTextureComponent forwardButton;
- - public ClickableTextureComponent upgradeIcon;
- - public ClickableTextureComponent demolishButton;
- - public ClickableTextureComponent moveButton;
- - public ClickableTextureComponent paintButton;
- - public ClickableTextureComponent appearanceButton;
- - public Building currentBuilding;
- - public Building buildingToMove;
- - public readonly List<Item> ingredients = new List<Item>();
- - public bool onFarm;
- - public CarpentryAction Action;
- - public bool drawBG = true;
- - public bool freeze;
- - public bool readOnly
- - public CarpenterMenu(string builder, GameLocation targetLocation = null)
- - public override bool shouldClampGamePadCursor()
- - public override void snapToDefaultClickableComponent()
- - public void SetNewActiveBlueprint(int index)
- - public void SetNewActiveBlueprint(BlueprintEntry blueprint)
- - public virtual void UpdateAppearanceButtonVisibility()
- - public override void performHoverAction(int x, int y)
- - public bool hasPermissionsToDemolish(Building b)
- - public bool HasPermissionsToPaint(Building b)
- - public bool hasPermissionsToMove(Building b)
- - public override void receiveGamePadButton(Buttons button)
- - public override void gamePadButtonHeld(Buttons b)
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)
- - public virtual bool ConfirmBuildingAccessibility(Vector2 buildingPosition)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public bool tryToBuild()
- - public virtual void returnToCarpentryMenu()
- - public void returnToCarpentryMenuAfterSuccessfulBuild()
- - public void robinConstructionMessage()
- - public override bool overrideSnappyMenuCursorMovementBan()
- - public void setUpForBuildingPlacement()
- - public Location GetInitialBuildingPlacementViewport(GameLocation location)
- - public override void gameWindowSizeChanged(Rectangle oldBounds, Rectangle newBounds)
- - public virtual bool IsValidBuildingForLocation(string typeId, BuildingData data, GameLocation targetLocation)
- - public virtual bool CanBuildCurrentBlueprint()
- - public bool CanDemolishThis()
- - public virtual bool CanDemolishThis(Building building)
- - public override void draw(SpriteBatch b)
- - public void ConsumeResources()
- - public bool DoesFarmerHaveEnoughResourcesToBuild()

## Private Members
- - private bool _readOnly;
- - private string hoverText = "";
- - private void resetBounds()

## Protected Members
- - protected bool VerifyTileAccessibility(int tileX, int tileY, Vector2 buildingPosition)

## Internal Members
- *(None)*

## Other Members
- - static Location CenterOnTile(int x, int y)
