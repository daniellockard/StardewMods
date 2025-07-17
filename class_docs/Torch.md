# Torch

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float yVelocity = 1f;
- - public const float yDissapearLevel = -100f;
- - public const double ashChance = 0.015;
- - public Torch()
- - public Torch(int initialStack)
- - public Torch(int initialStack, string itemId)
- - public Torch(string index, bool bigCraftable)
- - public override void RecalculateBoundingBox()
- - public override void actionOnPlayerEntry()
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public override bool placementAction(GameLocation location, int x, int y, Farmer who)
- - public override bool isPassable()
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override void performRemoveAction()
- - public override void draw(SpriteBatch spriteBatch, int xNonTile, int yNonTile, float layerDepth, float alpha = 1f)
- - public static void drawBasicTorch(SpriteBatch spriteBatch, float x, float y, float layerDepth, float alpha = 1f)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)
- - public struct InputButton
- - public Keys key;
- - public bool mouseLeft;
- - public bool mouseRight;
- - public InputButton(Keys key)
- - public InputButton(bool mouseLeft)
- - public override string ToString()
- - public enum ServerPrivacy

## Private Members
- - private float color;
- - private Vector2[] ashes = (Vector2[])(object)new Vector2[3];
- - private float smokePuffTimer;
- - private void updateAshes(int identifier)

## Protected Members
- - protected override void MigrateLegacyItemId()
- - protected override Item GetOneNew()

## Internal Members
- *(None)*

## Other Members
- *(None)*
