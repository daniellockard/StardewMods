# SocialEntry

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Character Character;
- - public readonly string InternalName;
- - public readonly string DisplayName;
- - public readonly bool IsMet;
- - public readonly bool IsDatable;
- - public readonly SocialTabBehavior SocialTabBehavior;
- - public readonly bool IsChild;
- - public readonly bool IsPlayer;
- - public readonly Gender Gender;
- - public readonly int HeartLevel;
- - public readonly Friendship Friendship;
- - public readonly CharacterData Data;
- - public int? OrderMet;
- - public SocialEntry(Farmer player, Friendship friendship)
- - public SocialEntry(NPC npc, Friendship friendship, CharacterData data, string overrideDisplayName = null)
- - public bool IsDatingCurrentPlayer()
- - public bool IsMarriedToCurrentPlayer()
- - public bool IsRoommateForCurrentPlayer()
- - public bool IsDivorcedFromCurrentPlayer()
- - public bool IsMarriedToAnyone()
- - public const int slotsOnPage = 5;
- - public string hoverText = "";
- - public ClickableTextureComponent upButton;
- - public ClickableTextureComponent downButton;
- - public ClickableTextureComponent scrollBar;
- - public Rectangle scrollBarRunner;
- - public readonly List<SocialEntry> SocialEntries;
- - public readonly List<ClickableTextureComponent> sprites = new List<ClickableTextureComponent>();
- - public int slotPosition;
- - public int numFarmers;
- - public readonly List<ClickableTextureComponent> characterSlots = new List<ClickableTextureComponent>();
- - public bool scrolling;
- - public SocialPage(int x, int y, int width, int height)
- - public void postWindowSizeChange(IClickableMenu oldPage)
- - public List<SocialEntry> FindSocialCharacters()
- - public IEnumerable<NPC> GetAllNpcs()
- - public void CreateComponents()
- - public ClickableTextureComponent CreateSpriteComponent(SocialEntry entry, int index)
- - public SocialEntry GetSocialEntry(int index)
- - public override void snapToDefaultClickableComponent()
- - public void updateSlots()
- - public void addTabsToClickableComponents()
- - public void ConstrainSelectionToVisibleSlots()
- - public override void snapCursorToCurrentSnappedComponent()
- - public override void applyMovementKey(int direction)
- - public override void leftClickHeld(int x, int y)
- - public override void releaseLeftClick(int x, int y)
- - public override void receiveScrollWheelAction(int direction)
- - public void upArrowPressed()
- - public void downArrowPressed()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public bool isCharacterSlotClickable(int i)
- - public void drawNPCSlot(SpriteBatch b, int i)
- - public void drawNPCSlotHeart(SpriteBatch b, int npcIndex, SocialEntry entry, int hearts, bool isDating, bool isCurrentSpouse)
- - public int rowPosition(int i)
- - public void drawFarmerSlot(SpriteBatch b, int i)
- - public override void draw(SpriteBatch b)

## Private Members
- - private bool? CachedIsMarriedToAnyone;
- - private void setScrollBarToCurrentIndex()

## Protected Members
- - protected void _SelectSlot(SocialEntry entry)
- - protected void _SelectSlot(ClickableComponent slot_component)

## Internal Members
- *(None)*

## Other Members
- *(None)*
