# BaseEnchantment

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static bool hideEnchantmentName;
- - public static bool hideSecondaryEnchantName;
- - public NetFields NetFields { get; } = new NetFields("BaseEnchantment");
- - public int Level
- - public BaseEnchantment()
- - public static BaseEnchantment GetEnchantmentFromItem(Item base_item, Item item)
- - public static List<BaseEnchantment> GetAvailableEnchantmentsForItem(Tool item)
- - public static List<BaseEnchantment> GetAvailableEnchantments()
- - public static void ResetEnchantments()
- - public virtual bool IsForge()
- - public virtual bool IsSecondaryEnchantment()
- - public virtual void InitializeNetFields()
- - public void OnEquip(Farmer farmer)
- - public void OnUnequip(Farmer farmer)
- - public virtual void OnCalculateDamage(Monster monster, GameLocation location, Farmer who, bool fromBomb, ref int amount)
- - public virtual void OnDealtDamage(Monster monster, GameLocation location, Farmer who, bool fromBomb, int amount)
- - public virtual void OnMonsterSlay(Monster monster, GameLocation location, Farmer who, bool slainByBomb)
- - public virtual void AddEquipmentEffects(BuffEffects effects)
- - public void OnCutWeed(Vector2 tile_location, GameLocation location, Farmer who)
- - public virtual BaseEnchantment GetOne()
- - public int GetLevel()
- - public void SetLevel(Item item, int new_level)
- - public virtual int GetMaximumLevel()
- - public void ApplyTo(Item item, Farmer farmer = null)
- - public bool IsItemCurrentlyEquipped(Item item, Farmer farmer)
- - public void UnapplyTo(Item item, Farmer farmer = null)
- - public virtual bool CanApplyTo(Item item)
- - public string GetDisplayName()
- - public virtual string GetName()
- - public virtual bool ShouldBeDisplayed()

## Private Members
- *(None)*

## Protected Members
- - protected string _displayName;
- - protected bool _applied;
- - protected static List<BaseEnchantment> _enchantments;
- - protected readonly NetInt level = new NetInt(1);
- - protected virtual void _OnEquip(Farmer who)
- - protected virtual void _OnUnequip(Farmer who)
- - protected virtual void _OnCutWeed(Vector2 tile_location, GameLocation location, Farmer who)
- - protected virtual void _ApplyTo(Item item)
- - protected virtual bool _IsCurrentlyEquipped(Item item, Farmer farmer)
- - protected virtual void _UnapplyTo(Item item)

## Internal Members
- *(None)*

## Other Members
- *(None)*
