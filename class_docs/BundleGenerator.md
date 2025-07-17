# BundleGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public List<RandomBundleData> randomBundleData;
- - public Dictionary<string, string> bundleData;
- - public Random random;
- - public Dictionary<string, string> Generate(List<RandomBundleData> bundle_data, Random rng)
- - public string ParseRandomTags(string data)
- - public Item ParseItemString(string item_string)
- - public void ParseItemList(StringBuilder builder, string item_list, int pick_count, int required_items, int color)
- - public struct ButtonCollection
- - public struct ButtonEnumerator
- - public Buttons Current
- - public ButtonEnumerator(Buttons pressed)
- - public bool MoveNext()
- - public void Reset()
- - public int Count => _count;
- - public ButtonCollection(ref GamePadState padState, ref GamePadState oldPadState)
- - public ButtonCollection(ref GamePadState padState)
- - public ButtonEnumerator GetEnumerator()

## Private Members
- - private readonly Buttons _pressed;
- - private int _current;
- - private readonly Buttons _pressed;
- - private readonly int _count;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
