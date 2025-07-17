# FrameworkExtensions

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static Rectangle GetTitleSafeArea(this Viewport viewport)
- - public static IEnumerable<Point> GetPoints(this Rectangle rect)
- - public static IEnumerable<Vector2> GetVectors(this Rectangle rect)
- - public static Rectangle Clone(this Rectangle rect)
- - public static Vector2 Size(this Viewport vp)
- - public static int GetElementCount(this Texture2D texture)
- - public static int GetActualWidth(this Texture2D texture)
- - public static int GetActualHeight(this Texture2D texture)
- - public static void SetContentSize(this Texture2D texture, int width, int height)
- - public static bool TryGetValue(this IPropertyCollection properties, string key, out string value)
- - public static bool TryAdd(this IPropertyCollection properties, string key, string value)
- - public static Layer RequireLayer(this Map map, string layerId)
- - public static TileSheet RequireTileSheet(this Map map, string tilesheetId)
- - public static TileSheet RequireTileSheet(this Map map, int expectedIndex, string tilesheetId)
- - public static bool HasTileAt(this Map map, Location tile, string layerId, string tilesheetId = null)
- - public static bool HasTileAt(this Map map, int x, int y, string layerId, string tilesheetId = null)
- - public static int GetTileIndexAt(this Map map, int x, int y, string layerId, string tilesheetId = null)
- - public static int GetTileIndexAt(this Map map, Location tile, string layerId, string tilesheetId = null)
- - public static bool HasTileAt(this Layer layer, Location tile, string tilesheetId = null)
- - public static bool HasTileAt(this Layer layer, int x, int y, string tilesheetId = null)
- - public static int GetTileIndexAt(this Layer layer, Location tile, string tilesheetId = null)
- - public static int GetTileIndexAt(this Layer layer, int x, int y, string tilesheetId = null)
- - public static Rectangle ToXna(this Rectangle xrect)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
