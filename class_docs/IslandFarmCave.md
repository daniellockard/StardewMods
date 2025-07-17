# IslandFarmCave

**Summary:** Represents the player's farm, its state, and related locations.

## Public Members
- - public NPC gourmand;
- - public NetInt gourmandRequestsFulfilled = new NetInt();
- - public NetEvent0 requestGourmandCheckEvent = new NetEvent0();
- - public NetEvent1Field<string, NetString> gourmandResponseEvent = new NetEvent1Field<string, NetString>();
- - public bool triggeredGourmand;
- - public static int TOTAL_GOURMAND_REQUESTS = 3;
- - public IslandFarmCave()
- - public IslandFarmCave(string map, string name)
- - public virtual void OnRequestGourmandCheck()
- - public int GetRelativeDirection(Point source, Point destination)
- - public Point FindNearbyUnoccupiedTileThatFitsCharacter(GameLocation location, int target_x, int target_y, int width = 1, Point? invalid_tile = null)
- - public virtual void OnGourmandResponse(string response)
- - public virtual void CompleteGourmandRequest()
- - public virtual void GiveReward()
- - public void ShowGourmandUnhappy()
- - public override void draw(SpriteBatch b)
- - public override void DayUpdate(int dayOfMonth)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
- - public virtual void TalkToGourmand()
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public string IndexForRequest(int request_number)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override void TransferDataFromSavedLocation(GameLocation l)

## Private Members
- - private NetMutex gourmandMutex = new NetMutex();
- - private Texture2D smokeTexture;
- - private float smokeTimer;

## Protected Members
- - protected override void initNetFields()
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
