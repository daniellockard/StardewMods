# FarmhandSlot

**Summary:** Represents the player's farm, its state, and related locations.

## Public Members
- - public bool BelongsToAnotherPlayer()
- - public FarmhandSlot(FarmhandMenu menu, Farmer farmer)
- - public override void Activate()
- - public override float getSlotAlpha()
- - public bool gettingFarmhands;
- - public bool approvingFarmhand;
- - public Client client;
- - public FarmhandMenu()
- - public FarmhandMenu(Client client)
- - public override bool readyToClose()
- - public override void UpdateButtons()
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override bool IsAutomaticSnapValid(int direction, ClickableComponent a, ClickableComponent b)
- - public override void update(GameTime time)

## Private Members
- - private void loadClientOptions()

## Protected Members
- - protected new FarmhandMenu menu;
- - protected bool _belongsToAnotherPlayer;
- - protected override void drawSlotName(SpriteBatch b, int i)
- - protected override void drawSlotShadow(SpriteBatch b, int i)
- - protected override void drawSlotFarmer(SpriteBatch b, int i)
- - protected override void drawSlotTimer(SpriteBatch b, int i)
- - protected override void drawSlotMoney(SpriteBatch b, int i)
- - protected override bool hasDeleteButtons()
- - protected override void startListPopulation(string filter)
- - protected override bool checkListPopulation()
- - protected override string getStatusText()
- - protected override void Dispose(bool disposing)

## Internal Members
- *(None)*

## Other Members
- - static void LoadOptions()
