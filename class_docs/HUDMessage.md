# HUDMessage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float defaultTime = 3500f;
- - public const int achievement_type = 1;
- - public const int newQuest_type = 2;
- - public const int error_type = 3;
- - public const int stamina_type = 4;
- - public const int health_type = 5;
- - public const int screenshot_type = 6;
- - public string message;
- - public string type;
- - public float timeLeft;
- - public float transparency = 1f;
- - public int number = -1;
- - public int whatType;
- - public bool achievement;
- - public bool noIcon;
- - public Item messageSubject;
- - public HUDMessage(string message)
- - public HUDMessage(string message, int whatType)
- - public HUDMessage(string message, float timeLeft, bool fadeIn = false)
- - public static HUDMessage ForItemGained(Item item, int count, string type = null)
- - public static HUDMessage ForCornerTextbox(string message)
- - public static HUDMessage ForAchievement(string achievementName)
- - public virtual bool update(GameTime time)
- - public virtual void draw(SpriteBatch b, int i, ref int heightUsed)
- - public static void numbersEasterEgg(int number)
- - public interface IHaveModData

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
