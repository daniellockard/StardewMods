# LibraryMuseum

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int dwarvenGuide = 0;
- - public const int totalNotes = 21;
- - public static int totalArtifacts
- - public NetVector2Dictionary<string, NetString> museumPieces => Game1.netWorldState.Value.MuseumPieces;
- - public LibraryMuseum()
- - public LibraryMuseum(string mapPath, string name)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool skipWasUpdatedFlush = false)
- - public static bool HasDonatedArtifacts()
- - public static bool HasDonatedArtifactAt(Vector2 tile)
- - public static bool HasDonatedArtifact(string itemId)
- - public bool isItemSuitableForDonation(Item i)
- - public static bool IsItemSuitableForDonation(string itemId, bool checkDonatedItems = true)
- - public bool doesFarmerHaveAnythingToDonate(Farmer who)
- - public override void cleanupBeforePlayerExit()
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public string getRewardItemKey(Item item)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public List<Item> getRewardsForPlayer(Farmer player)
- - public void AddNonItemRewards(MuseumRewards data, string rewardId, Farmer player)
- - public bool AddRewardItemIfUncollected(Farmer player, List<Item> rewards, Item rewardItem)
- - public bool HighlightCollectableRewards(Item item)
- - public void OpenRearrangeMenu()
- - public void OpenRewardMenu()
- - public void OpenDonationMenu()
- - public void OnDonationMenuClosed()
- - public void OnRewardCollected(Item item, Farmer who)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public bool isTileSuitableForMuseumPiece(int x, int y)
- - public Dictionary<string, int> GetDonatedByContextTag(Dictionary<string, MuseumRewards> museumRewardData)
- - public bool CanCollectReward(MuseumRewards reward, string rewardId, Farmer player, Dictionary<string, int> countsByTag)
- - public Rectangle getMuseumDonationBounds()
- - public Vector2 getFreeDonationSpot()
- - public Vector2 findMuseumPieceLocationInDirection(Vector2 startingPoint, int direction, int distanceToCheck = 8, bool ignoreExistingItems = true)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public override void draw(SpriteBatch b)

## Private Members
- - private readonly NetMutex mutex = new NetMutex();
- - private Dictionary<int, Vector2> getLostBooksLocations()
- - private void OpenGuntherDialogueMenu()

## Protected Members
- - protected static int _totalArtifacts = -1;
- - protected Dictionary<Item, string> _itemToRewardsLookup = new Dictionary<Item, string>();
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
