# Buff

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const float glowRate = 0.05f;
- - public const int ENDLESS = -2;
- - public const int farming = 0;
- - public const int fishing = 1;
- - public const int mining = 2;
- - public const int luck = 4;
- - public const int foraging = 5;
- - public const int maxStamina = 7;
- - public const int magneticRadius = 8;
- - public const int speed = 9;
- - public const int defense = 10;
- - public const int attack = 11;
- - public const string goblinsCurse = "12";
- - public const string slimed = "13";
- - public const string evilEye = "14";
- - public const string tipsy = "17";
- - public const string fear = "18";
- - public const string frozen = "19";
- - public const string warriorEnergy = "20";
- - public const string yobaBlessing = "21";
- - public const string adrenalineRush = "22";
- - public const string avoidMonsters = "23";
- - public const string full = "6";
- - public const string quenched = "7";
- - public const string spawnMonsters = "24";
- - public const string nauseous = "25";
- - public const string darkness = "26";
- - public const string weakness = "27";
- - public const string squidInkRavioli = "28";
- - public const int fullnessLength = 180000;
- - public const int quenchedLength = 60000;
- - public int millisecondsDuration;
- - public int totalMillisecondsDuration;
- - public readonly BuffEffects effects = new BuffEffects();
- - public readonly string id;
- - public string displayName;
- - public string description;
- - public string source;
- - public string displaySource;
- - public Texture2D iconTexture;
- - public int iconSheetIndex;
- - public Color glow;
- - public float displayAlphaTimer;
- - public bool alreadyUpdatedIconAlpha;
- - public string[] actionsOnApply;
- - public bool visible = true;
- - public readonly Dictionary<string, string> customFields = new Dictionary<string, string>();
- - public Buff(string id, string source = null, string displaySource = null, int duration = -1, Texture2D iconTexture = null, int iconSheetIndex = -1, BuffEffects effects = null, bool? isDebuff = null, string displayName = null, string description = null)
- - public bool HasAnyEffects()
- - public string getTimeLeft()
- - public virtual bool update(GameTime time)
- - public virtual void OnAdded()
- - public virtual void OnRemoved()

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
