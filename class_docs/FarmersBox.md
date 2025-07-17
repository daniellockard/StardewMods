# FarmersBox

**Summary:** Represents the player character, including stats, inventory, and actions.

## Public Members
- - public float _updateTimer;
- - public FarmersBox()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void update(GameTime time)
- - public void draw(SpriteBatch b, int left, int bottom, ClickableComponent current, List<ClickableComponent> parentComponents)

## Private Members
- - private readonly List<Farmer> _farmers = new List<Farmer>();
- - private void UpdateFarmers(List<ClickableComponent> parentComponents)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
