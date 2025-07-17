# BuffsDisplay

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static readonly List<BuffAttributeDisplay> displayAttributes = new List<BuffAttributeDisplay>
- - public readonly HashSet<string> updatedIDs = new HashSet<string>();
- - public bool dirty;
- - public string hoverText = "";
- - public BuffsDisplay()
- - public override bool isWithinBounds(int x, int y)
- - public int getNumBuffs()
- - public override void performHoverAction(int x, int y)
- - public string[] getBuffDescriptionTextReplacement(string buffName)
- - public void arrangeTheseComponentsInThisRectangle(int rectangleX, int rectangleY, int rectangleWidthInComponentWidthUnits, int componentWidth, int componentHeight, int buffer, bool rightToLeft)
- - public new void update(GameTime time)
- - public override void draw(SpriteBatch b)
- - public IEnumerable<Buff> GetSortedBuffs()
- - public virtual IEnumerable<ClickableTextureComponent> getClickableComponents(Buff buff)

## Private Members
- - private readonly Dictionary<ClickableTextureComponent, Buff> buffs = new Dictionary<ClickableTextureComponent, Buff>();
- - private void updatePosition()

## Protected Members
- - protected virtual void resetIcons()
- - protected virtual string getDescription(Buff buff)
- - protected virtual string getDescription(Buff buff, BuffAttributeDisplay attribute, bool withSource)
- - protected virtual string getSourceLine(Buff buff)

## Internal Members
- *(None)*

## Other Members
- *(None)*
