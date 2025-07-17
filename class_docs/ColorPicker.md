# ColorPicker

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int sliderChunks = 24;
- - public SliderBar hueBar;
- - public SliderBar valueBar;
- - public SliderBar saturationBar;
- - public SliderBar recentSliderBar;
- - public string Name;
- - public Color LastColor;
- - public bool Dirty;
- - public ColorPicker(string name, int x, int y)
- - public Color getSelectedColor()
- - public Color click(int x, int y)
- - public void changeHue(int amount)
- - public void changeSaturation(int amount)
- - public void changeValue(int amount)
- - public Color clickHeld(int x, int y)
- - public void releaseClick()
- - public void draw(SpriteBatch b)
- - public bool containsPoint(int x, int y)
- - public void setColor(Color color)
- - public void setHsvColor(float hue, float sat, float value)
- - public static void RGBtoHSV(float r, float g, float b, out float h, out float s, out float v)
- - public static Color HsvToRgb(double hue, double saturation, double value)
- - public static int Clamp(int value)

## Private Members
- - private Rectangle bounds;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
