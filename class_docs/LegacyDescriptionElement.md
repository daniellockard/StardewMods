# LegacyDescriptionElement

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public string xmlKey;
- - public List<object> param;
- - public Version GameVersion { get; } = new Version(1, 5);
- - public bool ApplySaveFix(SaveFixes saveFix)
- - public static void ConvertBuildingsToData(GameLocation location)
- - public static void TransferValuesToDataBuilding(Building oldBuilding, Building newBuilding)
- - public static void MigrateFarmhands(List<GameLocation> locations)
- - public static void StandardizeBundleFields(Dictionary<string, string> bundleData)
- - public static string InferBuildingUpgradingTo(string fromBuildingType)
- - public static void InferMachineInputOutputFields(Object machine)
- - public static void MigrateLegacyDescriptionElement(Lazy<XmlSerializer> serializer, DescriptionElement element)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
