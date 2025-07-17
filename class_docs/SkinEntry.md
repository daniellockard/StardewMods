# SkinEntry

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int Index;
- - public readonly string Id;
- - public readonly string DisplayName;
- - public readonly string Description;
- - public readonly BuildingSkin Data;
- - public SkinEntry(int index, BuildingSkin skin)
- - public SkinEntry(int index, BuildingSkin skin, string displayName, string description)
- - public const int region_okButton = 101;
- - public const int region_nextSkin = 102;
- - public const int region_prevSkin = 103;
- - public static int WindowWidth = 576;
- - public static int WindowHeight = 576;
- - public Rectangle PreviewPane;
- - public ClickableTextureComponent OkButton;
- - public Building Building;
- - public ClickableTextureComponent NextSkinButton;
- - public ClickableTextureComponent PreviousSkinButton;
- - public string BuildingDisplayName;
- - public string BuildingDescription;
- - public List<SkinEntry> Skins = new List<SkinEntry>();
- - public SkinEntry Skin;
- - public BuildingSkinMenu(Building targetBuilding, bool ignoreSeparateConstructionEntries = false)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveGamePadButton(Buttons button)
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public void SetSkin(int index)
- - public virtual void SetSkin(SkinEntry skin)
- - public override void performHoverAction(int x, int y)
- - public virtual void RepositionElements()
- - public virtual bool SaveColor()
- - public virtual void SetRegion(int newRegion)
- - public override void draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
