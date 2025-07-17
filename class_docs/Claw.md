# Claw

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public float openAngle
- - public Claw(CraneGame game)
- - public void CheckDropPrize()
- - public void ApplyDrawEffectToArms(DrawEffect new_effect)
- - public void ReleaseGrabbedObject()
- - public void GrabObject()
- - public Prize GetGrabbedPrize()
- - public override void Update(GameTime time)
- - public override void Destroy()

## Private Members
- *(None)*

## Protected Members
- - protected CraneGameObject _leftArm;
- - protected CraneGameObject _rightArm;
- - protected Prize _grabbedPrize;
- - protected Vector2 _prizePositionOffset;
- - protected int _nextDropCheckTimer;
- - protected int _dropChances;
- - protected int _grabTime;

## Internal Members
- *(None)*

## Other Members
- *(None)*
