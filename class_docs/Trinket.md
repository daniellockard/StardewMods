# Trinket

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetString displayNameOverrideTemplate = new NetString();
- - public readonly NetStringList descriptionSubstitutionTemplates = new NetStringList();
- - public readonly NetStringDictionary<string, NetString> trinketMetadata = new NetStringDictionary<string, NetString>();
- - public readonly NetInt generationSeed = new NetInt();
- - public override string TypeDefinitionId { get; } = "(TR)";
- - public Trinket()
- - public Trinket(string itemId, int generationSeed)
- - public static bool CanSpawnTrinket(Farmer f)
- - public static void SpawnTrinket(GameLocation location, Vector2 spawnPoint)
- - public bool RerollStats(int newSeed)
- - public override bool canBeShipped()
- - public override int sellToStorePrice(long specificPlayerID = -1L)
- - public static void TrySpawnTrinket(GameLocation location, Monster monster, Vector2 spawnPosition, double chanceModifier = 1.0)
- - public static Trinket GetRandomTrinket()
- - public override bool canBeGivenAsGift()
- - public override void reloadSprite()
- - public TrinketData GetTrinketData()
- - public virtual TrinketEffect GetEffect()
- - public override int maximumStackSize()
- - public override string getDescription()
- - public override string getCategoryName()
- - public override Color getCategoryColor()
- - public override bool isPlaceable()
- - public override bool performUseAction(GameLocation location)
- - public override bool performToolAction(Tool t)
- - public override bool IsHeldOverHead()
- - public virtual void Apply(Farmer farmer)
- - public virtual void Unapply(Farmer farmer)
- - public virtual void Update(Farmer farmer, GameTime time, GameLocation location)
- - public virtual void OnFootstep(Farmer farmer)
- - public virtual void OnReceiveDamage(Farmer farmer, int damageAmount)
- - public virtual void OnDamageMonster(Farmer farmer, Monster monster, int damageAmount, bool isBomb, bool isCriticalHit)

## Private Members
- *(None)*

## Protected Members
- - protected string _description;
- - protected TrinketData _data;
- - protected TrinketEffect _trinketEffect;
- - protected string _trinketEffectClassName;
- - protected string displayNameOverride;
- - protected override void initNetFields()
- - protected override string loadDisplayName()
- - protected override Item GetOneNew()
- - protected override void GetOneCopyFrom(Item source)

## Internal Members
- *(None)*

## Other Members
- *(None)*
