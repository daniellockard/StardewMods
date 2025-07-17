# DelayedAction

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int timeUntilAction;
- - public int intData;
- - public float floatData;
- - public string stringData;
- - public Point pointData;
- - public NPC character;
- - public GameLocation location;
- - public Action behavior;
- - public Game1.afterFadeFunction afterFadeBehavior;
- - public bool waitUntilMenusGone;
- - public TemporaryAnimatedSprite temporarySpriteData;
- - public DelayedAction(int delay)
- - public DelayedAction(int delay, Action behavior)
- - public bool update(GameTime time)
- - public static void warpAfterDelay(string targetLocation, Point targetTile, int delay)
- - public static void addTemporarySpriteAfterDelay(TemporaryAnimatedSprite sprite, GameLocation location, int delay, bool waitUntilMenusGone = false)
- - public static void playSoundAfterDelay(string soundName, int delay, GameLocation location = null, Vector2? position = null, int pitch = -1, bool local = false)
- - public static void removeTemporarySpriteAfterDelay(GameLocation location, int idOfTempSprite, int delay)
- - public static DelayedAction playMusicAfterDelay(string musicName, int delay, bool interruptable = true)
- - public static void textAboveHeadAfterDelay(string text, NPC who, int delay)
- - public static void stopFarmerGlowing(int delay)
- - public static void showDialogueAfterDelay(string dialogue, int delay)
- - public static void screenFlashAfterDelay(float intensity, int delay, string sound = null)
- - public static void removeTileAfterDelay(int x, int y, int delay, GameLocation location, string whichLayer)
- - public static void fadeAfterDelay(Game1.afterFadeFunction behaviorAfterFade, int delay)
- - public static DelayedAction functionAfterDelay(Action func, int delay)
- - public delegate void ReportHasRoomAnotherFarmDelegate(bool yes);

## Private Members
- - private void ApplyFade()
- - private void ApplyTextAboveHead()
- - private void ApplyTempSprite()
- - private void ApplyStopGlowing()
- - private void ApplyDialogue()
- - private void ApplyWarp()
- - private void ApplyRemoveMapTile()
- - private void ApplyRemoveTemporarySprite()
- - private void ApplySoundHelper(bool local)
- - private void ApplySound()
- - private void ApplySoundLocal()
- - private void ApplyMusicTrack()
- - private void ApplyScreenFlash()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
