# BuffManager

**Summary:** Handles or manages a specific system or feature.

## Public Members
- - public readonly IDictionary<string, Buff> AppliedBuffs = new Dictionary<string, Buff>();
- - public readonly NetStringList AppliedBuffIds = new NetStringList();
- - public bool Dirty = true;
- - public NetFields NetFields { get; } = new NetFields("BuffManager");
- - public int CombatLevel => (int)GetValues().CombatLevel.Value;
- - public int FarmingLevel => (int)GetValues().FarmingLevel.Value;
- - public int FishingLevel => (int)GetValues().FishingLevel.Value;
- - public int MiningLevel => (int)GetValues().MiningLevel.Value;
- - public int LuckLevel => (int)GetValues().LuckLevel.Value;
- - public int ForagingLevel => (int)GetValues().ForagingLevel.Value;
- - public int MaxStamina => (int)GetValues().MaxStamina.Value;
- - public int MagneticRadius => (int)GetValues().MagneticRadius.Value;
- - public float Speed => GetValues().Speed.Value;
- - public int Defense => (int)GetValues().Defense.Value;
- - public int Attack => (int)GetValues().Attack.Value;
- - public int Immunity => (int)GetValues().Immunity.Value;
- - public float AttackMultiplier => GetValues().AttackMultiplier.Value;
- - public float KnockbackMultiplier => GetValues().KnockbackMultiplier.Value;
- - public float WeaponSpeedMultiplier => GetValues().WeaponSpeedMultiplier.Value;
- - public float CriticalChanceMultiplier => GetValues().CriticalChanceMultiplier.Value;
- - public float CriticalPowerMultiplier => GetValues().CriticalPowerMultiplier.Value;
- - public float WeaponPrecisionMultiplier => GetValues().WeaponPrecisionMultiplier.Value;
- - public BuffManager()
- - public virtual BuffEffects GetValues()
- - public void SetOwner(Farmer player)
- - public bool IsApplied(string id)
- - public bool HasBuffWithNameContaining(string idSubstring)
- - public virtual bool IsLocallyControlled()
- - public void Apply(Buff buff)
- - public void Remove(string id)
- - public void Clear()
- - public void Update(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected Farmer Player;
- - protected readonly BuffEffects CombinedEffects = new BuffEffects();

## Internal Members
- *(None)*

## Other Members
- *(None)*
