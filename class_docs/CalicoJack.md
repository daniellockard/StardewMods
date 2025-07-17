# CalicoJack

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int cardState_flipped = -1;
- - public const int cardState_up = 0;
- - public const int cardState_transitioning = 400;
- - public const int bet = 100;
- - public const int cardWidth = 96;
- - public const int dealTime = 1000;
- - public const int playingTo = 21;
- - public const int passNumber = 18;
- - public const int dealerTurnDelay = 1000;
- - public List<int[]> playerCards;
- - public List<int[]> dealerCards;
- - public CalicoJack(int toBet = -1, bool highStakes = false)
- - public void RepositionButtons()
- - public bool overrideFreeMouseMovement()
- - public bool playButtonsActive()
- - public bool tick(GameTime time)
- - public void endGame()
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void leftClickHeld(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void draw(SpriteBatch b)
- - public void changeScreenSize()
- - public void unload()
- - public void receiveEventPoke(int data)
- - public string minigameId()
- - public bool doMainGameUpdates()
- - public bool forceQuit()

## Private Members
- - private Random r;
- - private int currentBet;
- - private int startTimer;
- - private int dealerTurnTimer = -1;
- - private int bustTimer;
- - private ClickableComponent hit;
- - private ClickableComponent stand;
- - private ClickableComponent doubleOrNothing;
- - private ClickableComponent playAgain;
- - private ClickableComponent quit;
- - private ClickableComponent currentlySnappedComponent;
- - private bool showingResultsScreen;
- - private bool playerWon;
- - private bool highStakes;
- - private string endMessage = "";
- - private string endTitle = "";
- - private string coinBuffer;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
