# Cask

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int defaultDaysToMature = 56;
- - public readonly NetFloat agingRate = new NetFloat();
- - public readonly NetFloat daysToMature = new NetFloat();
- - public override string TypeDefinitionId => "(BC)";
- - public Cask()
- - public Cask(Vector2 v)
- - public override bool performToolAction(Tool t)
- - public virtual bool IsValidCaskLocation()
- - public static Item OutputCask(Object machine, Item inputItem, bool probe, MachineItemOutput outputData, Farmer player, out int? overrideMinutesUntilReady)
- - public override bool TryApplyFairyDust(bool probe = false)
- - public override void DayUpdate()
- - public float GetDaysForQuality(int quality)
- - public int GetNextQuality(int quality)
- - public void checkForMaturity()
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
