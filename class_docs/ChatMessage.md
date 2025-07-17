# ChatMessage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public List<ChatSnippet> message = new List<ChatSnippet>();
- - public int timeLeftToDisplay;
- - public int verticalSize;
- - public float alpha = 1f;
- - public Color color;
- - public LocalizedContentManager.LanguageCode language;
- - public void parseMessageForEmoji(string messagePlaintext)
- - public static Color getColorFromName(string name)
- - public static string makeMessagePlaintext(List<ChatSnippet> message, bool include_color_information)
- - public void draw(SpriteBatch b, int x, int y)

## Private Members
- - private void breakNewLines(StringBuilder sb)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
