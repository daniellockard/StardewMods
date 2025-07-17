# ColorSliderPanel

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public BuildingPaintMenu buildingPaintMenu;
- - public int regionIndex;
- - public string regionId = "Paint Region Name";
- - public Rectangle rectangle;
- - public Vector2 colorDrawPosition;
- - public List<KeyValuePair<string, List<int>>> colors = new List<KeyValuePair<string, List<int>>>();
- - public int selectedColor;
- - public BuildingColorSlider hueSlider;
- - public BuildingColorSlider saturationSlider;
- - public BuildingColorSlider lightnessSlider;
- - public int minimumBrightness = -100;
- - public int maximumBrightness = 100;
- - public ColorSliderPanel(BuildingPaintMenu menu, int region_index, string regionId, int min_brightness = -100, int max_brightness = 100)
- - public virtual int GetHeight()
- - public virtual Rectangle Reposition(Rectangle start_rect)
- - public virtual void ApplyColors()
- - public virtual void Draw(SpriteBatch b)
- - public Color GetColorForValues(float hue_slider, float saturation_slider)
- - public Color GetColorForValues(float hue_slider, float saturation_slider, float lightness_slider)
- - public virtual bool ApplyMovementKey(int direction)
- - public virtual void PerformHoverAction(int x, int y)
- - public virtual bool ReceiveLeftClick(int x, int y, bool play_sound = true)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
