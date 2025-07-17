# MoneyDial

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int digitHeight = 8;
- - public int numDigits;
- - public int currentValue;
- - public int previousTargetValue;
- - public TemporaryAnimatedSpriteList animations = new TemporaryAnimatedSpriteList();
- - public Action<int> onPlaySound;
- - public bool ShouldShakeMainMoneyBox = true;
- - public MoneyDial(int numDigits, bool playSound = true)
- - public void playDefaultSound(int direction)
- - public void draw(SpriteBatch b, Vector2 position, int target)

## Private Members
- - private int speed;
- - private int soundTimer;
- - private int moneyMadeAccumulator;
- - private int moneyShineTimer;
- - private bool playSounds = true;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
