# TrashBear

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string itemWantedIndex;
- - public override bool IsVillager => false;
- - public TrashBear()
- - public override void ChooseAppearance(LocalizedContentManager content = null)
- - public override bool checkAction(Farmer who, GameLocation l)
- - public void updateItemWanted()
- - public override void update(GameTime time, GameLocation location)
- - public override bool tryToReceiveActiveObject(Farmer who, bool probe = false)
- - public void doEatEvent(string item_index)
- - public override void draw(SpriteBatch b)

## Private Members
- - private int showWantBubbleTimer;
- - private readonly NetEvent0 cutsceneEvent = new NetEvent0();
- - private readonly NetEvent1Field<string, NetString> eatEvent = new NetEvent1Field<string, NetString>();
- - private string itemBeingEaten;
- - private void throwUpItem(Farmer who)
- - private void chew(Farmer who)
- - private void doneAnimating(Farmer who)
- - private void doCutsceneEvent()
- - private void doCutscene()

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
