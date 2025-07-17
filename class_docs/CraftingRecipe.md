# CraftingRecipe

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int wild_seed_special_category = -777;
- - public const int index_ingredients = 0;
- - public const int index_output = 2;
- - public const int index_cookingUnlockConditions = 3;
- - public const int index_cookingDisplayName = 4;
- - public const int index_craftingBigCraftable = 3;
- - public const int index_craftingUnlockConditions = 4;
- - public const int index_craftingDisplayName = 5;
- - public string name;
- - public string DisplayName;
- - public string description;
- - public static Dictionary<string, string> craftingRecipes;
- - public static Dictionary<string, string> cookingRecipes;
- - public Dictionary<string, int> recipeList = new Dictionary<string, int>();
- - public List<string> itemToProduce = new List<string>();
- - public bool bigCraftable;
- - public bool isCookingRecipe;
- - public int timesCrafted;
- - public int numberProducedPerCraft;
- - public static void InitShared()
- - public CraftingRecipe(string name)
- - public CraftingRecipe(string name, bool isCookingRecipe)
- - public virtual string getIndexOfMenuView()
- - public virtual bool doesFarmerHaveIngredientsInInventory(IList<Item> extraToCheck = null)
- - public virtual void drawMenuView(SpriteBatch b, int x, int y, float layerDepth = 0.88f, bool shadow = true)
- - public virtual ParsedItemData GetItemData(bool useFirst = false)
- - public virtual Item createItem()
- - public static bool TryParseLevelRequirement(string id, string rawData, bool isCooking, out int skillNumber, out int minLevel, bool logErrors = true)
- - public static bool isThereSpecialIngredientRule(Item potentialIngredient, string requiredIngredient)
- - public virtual void consumeIngredients(List<IInventory> additionalMaterials)
- - public static bool DoesFarmerHaveAdditionalIngredientsInInventory(List<KeyValuePair<string, int>> additional_recipe_items, IList<Item> extraToCheck = null)
- - public static bool ItemMatchesForCrafting(Item item, string item_id)
- - public static void ConsumeAdditionalIngredients(List<KeyValuePair<string, int>> additionalRecipeItems, List<IInventory> additionalMaterials)
- - public virtual int getCraftableCount(IList<Chest> additional_material_chests)
- - public virtual int getCraftableCount(IList<Item> additional_materials)
- - public virtual string getCraftCountText()
- - public virtual int getDescriptionHeight(int width)
- - public virtual void drawRecipeDescription(SpriteBatch b, Vector2 position, int width, IList<Item> additional_crafting_items)
- - public virtual int getNumberOfIngredients()
- - public virtual string getSpriteIndexFromRawIndex(string item_id)
- - public virtual string getNameFromIndex(string item_id)

## Private Members
- - private void LogParseError(string rawData, string message)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
