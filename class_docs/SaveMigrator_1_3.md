# SaveMigrator_1_3

**Summary:** Handles saving or loading game data.

## Public Members
- - public Version GameVersion { get; } = new Version(1, 3);
- - public bool ApplySaveFix(SaveFixes saveFix)
- - public static void ApplyLegacyChanges()
- - public static void MarkFloorChestAsCollectedIfNecessary(int floorNumber)
- - public static void MigrateFriendshipData(Farmer player)

## Private Members
- - private static void MigrateHorseIds()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
