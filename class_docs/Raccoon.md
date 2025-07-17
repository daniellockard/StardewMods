# Raccoon

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool mrs_raccoon = new NetBool();
- - public readonly NetMutex mutex = new NetMutex();
- - public Raccoon()
- - public Raccoon(bool mrs_racooon = false)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public void activate()
- - public override void dayUpdate(int dayOfMonth)
- - public static Bundle GetBundle()
- - public static Bundle GetBundle(int timesFed)
- - public Item getBundleReward()
- - public override void update(GameTime time, GameLocation location)
- - public override bool checkAction(Farmer who, GameLocation l)
- - public override void performTenMinuteUpdate(int timeOfDay, GameLocation l)
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool wasTalkedTo;
- - private float updateFacingDirectionTimer;
- - private void _activateMrRaccoon()
- - private void bundleCompleteAfterSwipe(JunimoNoteMenu menu)
- - private void bundleComplete(JunimoNoteMenu menu)
- - private static void AddNextIngredient(List<BundleIngredientDescription> ingredients, int whichBundle, Random r)

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
