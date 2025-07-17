# Slots

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float slotTurnRate = 0.008f;
- - public const int numberOfIcons = 8;
- - public const int defaultBet = 10;
- - public bool spinning;
- - public bool showResult;
- - public float payoutModifier;
- - public int currentBet;
- - public int spinsCount;
- - public int slotsFinished;
- - public int endTimer;
- - public ClickableComponent currentlySnappedComponent;
- - public Slots(int toBet = -1, bool highStakes = false)
- - public void setSlotResults(List<float> toSet)
- - public bool tick(GameTime time)
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void leftClickHeld(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public bool overrideFreeMouseMovement()
- - public unsafe void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public int getIconIndex(int index)
- - public void draw(SpriteBatch b)
- - public void changeScreenSize()
- - public void unload()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()
- - public int GetButtonSizeOffset()

## Private Members
- - private string coinBuffer;
- - private List<float> slots;
- - private List<float> slotResults;
- - private ClickableComponent spinButton10;
- - private ClickableComponent spinButton100;
- - private ClickableComponent doneButton;
- - private ClickableComponent CreateSpinButton(int baseWidth, int yOffset, string nameTranslationKey)
- - private void set(List<float> toSet, int number)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
