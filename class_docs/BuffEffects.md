# BuffEffects

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetFloat CombatLevel = new NetFloat(0f);
- - public readonly NetFloat FarmingLevel = new NetFloat(0f);
- - public readonly NetFloat FishingLevel = new NetFloat(0f);
- - public readonly NetFloat MiningLevel = new NetFloat(0f);
- - public readonly NetFloat LuckLevel = new NetFloat(0f);
- - public readonly NetFloat ForagingLevel = new NetFloat(0f);
- - public readonly NetFloat MaxStamina = new NetFloat(0f);
- - public readonly NetFloat MagneticRadius = new NetFloat(0f);
- - public readonly NetFloat Speed = new NetFloat(0f);
- - public readonly NetFloat Defense = new NetFloat(0f);
- - public readonly NetFloat Attack = new NetFloat(0f);
- - public readonly NetFloat AttackMultiplier = new NetFloat(0f);
- - public readonly NetFloat Immunity = new NetFloat(0f);
- - public readonly NetFloat KnockbackMultiplier = new NetFloat(0f);
- - public readonly NetFloat WeaponSpeedMultiplier = new NetFloat(0f);
- - public readonly NetFloat CriticalChanceMultiplier = new NetFloat(0f);
- - public readonly NetFloat CriticalPowerMultiplier = new NetFloat(0f);
- - public readonly NetFloat WeaponPrecisionMultiplier = new NetFloat(0f);
- - public NetFields NetFields { get; } = new NetFields("BuffEffects");
- - public BuffEffects()
- - public BuffEffects(BuffAttributesData data)
- - public void Add(BuffEffects other)
- - public void Add(BuffAttributesData data)
- - public bool HasAnyValue()
- - public void Clear()
- - public string[] ToLegacyAttributeFormat()

## Private Members
- - private readonly NetFloat[] AdditiveFields;
- - private readonly NetFloat[] MultiplicativeFields;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
