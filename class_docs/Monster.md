# Monster

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public delegate void collisionBehavior(GameLocation location);
- - public const int index_health = 0;
- - public const int index_damageToFarmer = 1;
- - public const int index_isGlider = 4;
- - public const int index_drops = 6;
- - public const int index_resilience = 7;
- - public const int index_jitteriness = 8;
- - public const int index_distanceThresholdToMoveTowardsPlayer = 9;
- - public const int index_speed = 10;
- - public const int index_missChance = 11;
- - public const int index_isMineMonster = 12;
- - public const int index_experiencePoints = 13;
- - public const int index_displayName = 14;
- - public const int defaultInvincibleCountdown = 450;
- - public float timeBeforeAIMovementAgain;
- - public readonly NetInt damageToFarmer = new NetInt();
- - public readonly NetIntDelta health = new NetIntDelta();
- - public readonly NetInt maxHealth = new NetInt();
- - public readonly NetInt resilience = new NetInt();
- - public readonly NetInt slipperiness = new NetInt(2);
- - public readonly NetInt experienceGained = new NetInt();
- - public readonly NetDouble jitteriness = new NetDouble();
- - public readonly NetDouble missChance = new NetDouble();
- - public readonly NetBool isGlider = new NetBool();
- - public readonly NetBool mineMonster = new NetBool();
- - public readonly NetBool hasSpecialItem = new NetBool();
- - public readonly NetFloat synchedRotation = new NetFloat().Interpolated(interpolate: true, wait: true);
- - public readonly NetStringList objectsToDrop = new NetStringList();
- - public int skipHorizontal;
- - public int invincibleCountdown;
- - public readonly NetInt defaultAnimationInterval = new NetInt(175);
- - public readonly NetInt stunTime = new NetInt(0);
- - public bool initializedForLocation;
- - public readonly NetBool netFocusedOnFarmers = new NetBool();
- - public readonly NetBool netWildernessFarmMonster = new NetBool();
- - public readonly NetBool ignoreDamageLOS = new NetBool();
- - public collisionBehavior onCollision;
- - public NetBool isHardModeMonster = new NetBool(value: false);
- - public Farmer Player => findPlayer();
- - public int DamageToFarmer
- - public int Health
- - public int MaxHealth
- - public int ExperienceGained
- - public int Slipperiness
- - public bool focusedOnFarmers
- - public bool wildernessFarmMonster
- - public override bool IsMonster => true;
- - public override bool IsVillager => false;
- - public Monster()
- - public Monster(string name, Vector2 position)
- - public virtual void onDealContactDamage(Farmer who)
- - public virtual List<Item> getExtraDropItems()
- - public override bool withinPlayerThreshold()
- - public Monster(string name, Vector2 position, int facingDir)
- - public virtual bool ShouldMonsterBeRemoved()
- - public virtual void drawAboveAllLayers(SpriteBatch b)
- - public override void draw(SpriteBatch b)
- - public virtual bool isInvincible()
- - public void setInvincibleCountdown(int time)
- - public virtual Debris ModifyMonsterLoot(Debris debris)
- - public virtual int GetBaseDifficultyLevel()
- - public virtual void BuffForAdditionalDifficulty(int additional_difficulty)
- - public new static string GetDisplayName(string name)
- - public virtual void InitializeForLocation(GameLocation location)
- - public override void reloadSprite(bool onlyAppearance = false)
- - public override void ChooseAppearance(LocalizedContentManager content = null)
- - public virtual void shedChunks(int number)
- - public virtual void shedChunks(int number, float scale)
- - public void deathAnimation()
- - public void parried(int damage, Farmer who)
- - public virtual int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, Farmer who)
- - public int takeDamage(int damage, int xTrajectory, int yTrajectory, bool isBomb, double addedPrecision, string hitSound)
- - public override void setTrajectory(Vector2 trajectory)
- - public virtual void behaviorAtGameTick(GameTime time)
- - public override bool shouldCollideWithBuildingLayer(GameLocation location)
- - public override void update(GameTime time, GameLocation location)
- - public virtual bool ShouldActuallyMoveAwayFromPlayer()
- - public override void updateMovement(GameLocation location, GameTime time)
- - public virtual void noMovementProgressNearPlayerBehavior()
- - public virtual void defaultMovementBehavior(GameTime time)
- - public virtual bool TakesDamageFromHitbox(Rectangle area_of_effect)
- - public virtual bool OverlapsFarmerForDamage(Farmer who)
- - public override void Halt()
- - public override void MovePosition(GameTime time, Rectangle viewport, GameLocation currentLocation)

## Private Members
- - private readonly NetEvent1<ParryEventArgs> parryEvent = new NetEvent1<ParryEventArgs>
- - private readonly NetEvent1Field<Vector2, NetVector2> trajectoryEvent = new NetEvent1Field<Vector2, NetVector2>
- - private readonly NetEvent0 deathAnimEvent = new NetEvent0();
- - private int slideAnimationTimer;
- - private void handleParried(ParryEventArgs args)
- - private void doSetTrajectory(Vector2 trajectory)
- - private void checkHorizontalMovement(ref bool success, ref bool setMoving, ref bool scootSuccess, Farmer who, GameLocation location)
- - private void checkVerticalMovement(ref bool success, ref bool setMoving, ref bool scootSuccess, Farmer who, GameLocation location)

## Protected Members
- - protected override void initNetFields()
- - protected override Farmer findPlayer()
- - protected virtual double findPlayerPriority(Farmer f)
- - protected int maxTimesReachedMineBottom()
- - protected void parseMonsterInfo(string name)
- - protected virtual void sharedDeathAnimation()
- - protected virtual void localDeathAnimation()
- - protected void resetAnimationSpeed()
- - protected virtual void updateAnimation(GameTime time)
- - protected override void updateSlaveAnimation(GameTime time)
- - protected virtual void updateMonsterSlaveAnimation(GameTime time)
- - protected virtual string GenerateLightSourceId(int identifier)

## Internal Members
- *(None)*

## Other Members
- *(None)*
