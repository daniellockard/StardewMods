# BuildingColorSlider

**Summary:** Represents a building on the farm (barn, coop, etc.).

## Public Members
- - public ClickableTextureComponent handle;
- - public BuildingPaintMenu buildingPaintMenu;
- - public Rectangle bounds;
- - public int min;
- - public int max;
- - public Action<int> onValueSet;
- - public Func<float, Color> getDrawColor;
- - public BuildingColorSlider(BuildingPaintMenu bpm, int handle_id, Rectangle bounds, int min, int max, Action<int> on_value_set = null)
- - public virtual void ApplyMovementKey(int direction)
- - public virtual void ReceiveLeftClick(int x, int y)
- - public virtual void SetValueFromPosition(int x, int y)
- - public void SetValue(int value, bool skip_value_set = false)
- - public int GetValue()
- - public virtual void Draw(SpriteBatch b)
- - public virtual void Update(int x, int y)
- - public const int region_colorButtons = 1000;
- - public const int region_okButton = 101;
- - public const int region_nextRegion = 102;
- - public const int region_prevRegion = 103;
- - public const int region_copyColor = 104;
- - public const int region_defaultColor = 105;
- - public const int region_hueSlider = 106;
- - public const int region_saturationSlider = 107;
- - public const int region_lightnessSlider = 108;
- - public const int region_appearanceButton = 109;
- - public static int WINDOW_WIDTH = 1024;
- - public static int WINDOW_HEIGHT = 576;
- - public Rectangle previewPane;
- - public Rectangle colorPane;
- - public BuildingColorSlider activeSlider;
- - public ClickableTextureComponent appearanceButton;
- - public ClickableTextureComponent okButton;
- - public static List<Vector3> savedColors = null;
- - public List<Color> buttonColors = new List<Color>();
- - public ColorSliderPanel colorSliderPanel;
- - public Building building;
- - public string buildingType = "";
- - public BuildingPaintColor colorTarget;
- - public int currentPaintRegion;
- - public List<RegionData> regions;
- - public ClickableTextureComponent nextRegionButton;
- - public ClickableTextureComponent previousRegionButton;
- - public ClickableTextureComponent copyColorButton;
- - public ClickableTextureComponent defaultColorButton;
- - public List<ClickableTextureComponent> savedColorButtons = new List<ClickableTextureComponent>();
- - public List<ClickableComponent> sliderHandles = new List<ClickableComponent>();
- - public BuildingPaintMenu(Building target_building)
- - public virtual void InitializeSavedColors()
- - public override void snapToDefaultClickableComponent()
- - public override void applyMovementKey(int direction)
- - public override void receiveGamePadButton(Buttons button)
- - public override void update(GameTime time)
- - public override void releaseLeftClick(int x, int y)
- - public override void receiveRightClick(int x, int y, bool playSound = true)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public virtual void RepositionElements()
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public virtual bool SaveColor()
- - public virtual void SetRegion(int new_region)
- - public virtual void LoadRegionData()
- - public override void draw(SpriteBatch b)

## Private Members
- - private string hoverText = "";

## Protected Members
- - protected float _sliderPosition;
- - protected int _displayedValue;
- - protected Dictionary<string, string> _paintData;

## Internal Members
- *(None)*

## Other Members
- *(None)*
