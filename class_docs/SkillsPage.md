# SkillsPage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int region_special1 = 10201;
- - public const int region_special2 = 10202;
- - public const int region_special3 = 10203;
- - public const int region_special4 = 10204;
- - public const int region_special5 = 10205;
- - public const int region_special6 = 10206;
- - public const int region_special7 = 10207;
- - public const int region_special8 = 10208;
- - public const int region_special9 = 10209;
- - public const int region_special_skullkey = 10210;
- - public const int region_special_townkey = 10211;
- - public const int region_ccTracker = 30211;
- - public const int region_skillArea1 = 0;
- - public const int region_skillArea2 = 1;
- - public const int region_skillArea3 = 2;
- - public const int region_skillArea4 = 3;
- - public const int region_skillArea5 = 4;
- - public List<ClickableTextureComponent> skillBars = new List<ClickableTextureComponent>();
- - public List<ClickableTextureComponent> skillAreas = new List<ClickableTextureComponent>();
- - public List<ClickableTextureComponent> specialItems = new List<ClickableTextureComponent>();
- - public List<ClickableComponent> ccTrackerButtons = new List<ClickableComponent>();
- - public SkillsPage(int x, int y, int width, int height)
- - public override void snapToDefaultClickableComponent()
- - public override void receiveLeftClick(int x, int y, bool playSound = true)
- - public override void performHoverAction(int x, int y)
- - public override void draw(SpriteBatch b)

## Private Members
- - private string hoverText = "";
- - private string hoverTitle = "";
- - private int professionImage = -1;
- - private int playerPanelIndex;
- - private int playerPanelTimer;
- - private Rectangle playerPanel;
- - private int[] playerPanelFrames = new int[4] { 0, 1, 0, 2 };
- - private int timesClickedJunimo;
- - private void parseProfessionDescription(ref string professionBlurb, ref string professionTitle, List<string> professionDescription)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
