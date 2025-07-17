# ManorHouse

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public ManorHouse()
- - public ManorHouse(string mapPath, string name)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public override void MakeMapModifications(bool force = false)
- - public void CheckLostAndFound()
- - public List<Farmer> GetRetrievableFarmers()
- - public override void draw(SpriteBatch b)
- - public void ShowOfflineFarmhandItemList()
- - public void ChooseRecipient()
- - public void sendMoney(Farmer recipient, int amount)
- - public static void SeparateWallets()
- - public static void MergeWallets()
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)

## Private Members
- - private Dictionary<string, Farmer> sendMoneyMapping = new Dictionary<string, Farmer>();
- - private static readonly bool changeWalletTypeImmediately;
- - private void readLedgerBook()
- - private void beginSendMoney(Farmer recipient)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
