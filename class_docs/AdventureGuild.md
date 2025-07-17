# AdventureGuild

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NPC Gil = new NPC(null, new Vector2(-1000f, -1000f), "AdventureGuild", 2, "Gil", datable: false, Game1.content.Load<Texture2D>("Portraits\\Gil"));
- - public bool talkedToGil;
- - public AdventureGuild()
- - public AdventureGuild(string mapPath, string name)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override void draw(SpriteBatch b)
- - public void showMonsterKillList()
- - public static bool areAllMonsterSlayerQuestsComplete()
- - public static bool willThisKillCompleteAMonsterSlayerQuest(string nameOfMonster)
- - public void OnRewardCollected(Item item, Farmer who, List<KeyValuePair<string, MonsterSlayerQuestData>> completedGoals)
- - public static bool HasCollectedReward(Farmer player, string goalId)
- - public static bool IsComplete(MonsterSlayerQuestData goal)

## Private Members
- - private string killListLine(string monsterNamePlural, int killCount, int target)
- - private void gil()
- - private void OpenRewardMenuIfNeeded(List<Item> rewards, List<KeyValuePair<string, MonsterSlayerQuestData>> completedGoals)

## Protected Members
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
