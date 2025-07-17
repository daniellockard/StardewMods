# HungryFrogCompanion

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public float fullnessTime;
- - public HungryFrogCompanion()
- - public HungryFrogCompanion(int variant)
- - public override void InitNetFields()
- - public override void Update(GameTime time, GameLocation location)
- - public override void OnOwnerWarp()
- - public override void Hop(float amount)
- - public void tongueReachedMonster(Monster m)
- - public override void Draw(SpriteBatch b)

## Private Members
- - private const int RANGE = 300;
- - private const int FULLNESS_TIME = 12000;
- - private float monsterEatCheckTimer;
- - private float tongueOutTimer;
- - private readonly NetBool tongueOut = new NetBool(value: false);
- - private readonly NetBool tongueReturn = new NetBool(value: false);
- - private readonly NetPosition tonguePosition = new NetPosition();
- - private readonly NetVector2 tongueVelocity = new NetVector2();
- - private readonly NetNPCRef attachedMonsterField = new NetNPCRef();
- - private readonly NetEvent0 fullnessTrigger = new NetEvent0();
- - private float initialEquipDelay = 12000f;
- - private float lastHopTimer;
- - private Monster attachedMonster
- - private void triggerFullnessTimer()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
