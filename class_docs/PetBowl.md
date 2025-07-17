# PetBowl

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool watered = new NetBool();
- - public readonly NetGuid petId = new NetGuid();
- - public PetBowl(Vector2 tileLocation)
- - public PetBowl()
- - public virtual void AssignPet(Pet pet)
- - public virtual Point GetPetSpot()
- - public override bool doAction(Vector2 tileLocation, Farmer who)
- - public override void Update(GameTime time)
- - public override void performToolAction(Tool t, int tileX, int tileY)
- - public bool HasPet()
- - public override void draw(SpriteBatch b)

## Private Members
- - private int nameTimer;
- - private string nameTimerMessage;

## Protected Members
- - protected override void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
