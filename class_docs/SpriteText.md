# SpriteText

**Summary:** Represents a 2D image or animation.

## Public Members
- - public enum ScrollTextAlignment
- - public const int scrollStyle_scroll = 0;
- - public const int scrollStyle_speechBubble = 1;
- - public const int scrollStyle_darkMetal = 2;
- - public const int scrollStyle_blueMetal = 3;
- - public const int maxCharacter = 999999;
- - public const int maxHeight = 999999;
- - public const int characterWidth = 8;
- - public const int characterHeight = 16;
- - public const int horizontalSpaceBetweenCharacters = 0;
- - public const int verticalSpaceBetweenCharacters = 2;
- - public const char newLine = '^';
- - public static float fontPixelZoom = 3f;
- - public static float shadowAlpha = 0.15f;
- - public static Dictionary<char, FontChar> characterMap;
- - public static FontFile FontFile = null;
- - public static List<Texture2D> fontPages = null;
- - public static Texture2D spriteTexture;
- - public static Texture2D coloredTexture;
- - public const int color_index_Default = -1;
- - public const int color_index_Black = 0;
- - public const int color_index_Blue = 1;
- - public const int color_index_Red = 2;
- - public const int color_index_Purple = 3;
- - public const int color_index_White = 4;
- - public const int color_index_Orange = 5;
- - public const int color_index_Green = 6;
- - public const int color_index_Cyan = 7;
- - public const int color_index_Gray = 8;
- - public const int color_index_JojaBlue = 9;
- - public static bool forceEnglishFont = false;
- - public static float FontPixelZoom => fontPixelZoom + ((LocalizedContentManager.CurrentLanguageCode == LocalizedContentManager.LanguageCode.zh) ? ((Game1.options.dialogueFontScale - 1f) / (Game1.options.useChineseSmoothFont ? 4f : 2f)) : 0f);
- - public static Color color_Default
- - public static Color color_Black { get; } = Color.Black;
- - public static Color color_Blue { get; } = Color.SkyBlue;
- - public static Color color_Red { get; } = Color.Red;
- - public static Color color_Purple { get; } = new Color(110, 43, 255);
- - public static Color color_White { get; } = Color.White;
- - public static Color color_Orange { get; } = Color.OrangeRed;
- - public static Color color_Green { get; } = Color.LimeGreen;
- - public static Color color_Cyan { get; } = Color.Cyan;
- - public static Color color_Gray { get; } = new Color(60, 60, 60);
- - public static Color color_JojaBlue { get; } = new Color(52, 50, 122);
- - public static void drawStringHorizontallyCenteredAt(SpriteBatch b, string s, int x, int y, int characterPosition = 999999, int width = -1, int height = 999999, float alpha = 1f, float layerDepth = 0.88f, bool junimoText = false, Color? color = null, int maxWidth = 99999)
- - public static int getWidthOfString(string s, int widthConstraint = 999999)
- - public static bool IsMissingCharacters(string text)
- - public static int getHeightOfString(string s, int widthConstraint = 999999)
- - public static Color getColorFromIndex(int index)
- - public static string getSubstringBeyondHeight(string s, int width, int height)
- - public static int getIndexOfSubstringBeyondHeight(string s, int width, int height)
- - public static List<string> getStringBrokenIntoSectionsOfHeight(string s, int width, int height)
- - public static string getStringPreviousToThisHeightCutoff(string s, int width, int height)
- - public static int getWidthOffsetForChar(char c)
- - public static void drawStringWithScrollCenteredAt(SpriteBatch b, string s, int x, int y, int width, float alpha = 1f, Color? color = null, int scrollType = 0, float layerDepth = 0.88f, bool junimoText = false)
- - public static void drawSmallTextBubble(SpriteBatch b, string s, Vector2 positionOfBottomCenter, int maxWidth = -1, float layerDepth = -1f, bool drawPointerOnTop = false)
- - public static void drawStringWithScrollCenteredAt(SpriteBatch b, string s, int x, int y, string placeHolderWidthText = "", float alpha = 1f, Color? color = null, int scrollType = 0, float layerDepth = 0.88f, bool junimoText = false)
- - public static void drawStringWithScrollBackground(SpriteBatch b, string s, int x, int y, string placeHolderWidthText = "", float alpha = 1f, Color? color = null, ScrollTextAlignment scroll_text_alignment = ScrollTextAlignment.Left)
- - public static void drawString(SpriteBatch b, string s, int x, int y, int characterPosition = 999999, int width = -1, int height = 999999, float alpha = 1f, float layerDepth = 0.88f, bool junimoText = false, int drawBGScroll = -1, string placeHolderScrollWidthText = "", Color? color = null, ScrollTextAlignment scroll_text_alignment = ScrollTextAlignment.Left)
- - public static void LoadFontData(LocalizedContentManager.LanguageCode code)
- - public static int positionOfNextSpace(string s, int index, int currentXPosition, int accumulatedHorizontalSpaceBetweenCharacters)

## Private Members
- - private static int getLastSpace(string s, int startIndex)
- - private static FontFile loadFont(string assetName)
- - private static void setUpCharacterMap()
- - private static bool IsSpecialCharacter(char c)
- - private static void OnLanguageChange(LocalizedContentManager.LanguageCode code)
- - private static bool isUsingNonSpriteSheetFont()
- - private static Rectangle getSourceRectForChar(char c, bool junimoText)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
