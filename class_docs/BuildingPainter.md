# BuildingPainter

**Summary:** Represents a building on the farm (barn, coop, etc.).

## Public Members
- - public static Dictionary<string, List<List<int>>> paintMaskLookup = new Dictionary<string, List<List<int>>>(StringComparer.OrdinalIgnoreCase);
- - public static Texture2D Apply(Texture2D base_texture, string mask_path, BuildingPaintColor color)

## Private Members
- *(None)*

## Protected Members
- - protected static void _ApplyPaint(int h_shift, int s_shift, int l_shift, Color[] pixels, List<int> indices)

## Internal Members
- *(None)*

## Other Members
- *(None)*
