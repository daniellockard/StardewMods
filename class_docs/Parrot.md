# Parrot

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 position;
- - public float height;
- - public Texture2D texture;
- - public bool bounced;
- - public bool flipped;
- - public bool isPerchedParrot;
- - public float alpha;
- - public float moveTime;
- - public float moveDuration = 1f;
- - public bool firstBounce;
- - public bool flyAway;
- - public Parrot(ParrotUpgradePerch perch, Vector2 start_position, bool soundBird = false, bool goldenParrot = false)
- - public virtual void FindNewTarget()
- - public virtual bool Update(GameTime time)
- - public virtual void Draw(SpriteBatch b)
- - public const string GoldenParrotMailKey = "activateGoldenParrotsTonight";
- - public NetEvent0 animationEvent = new NetEvent0();
- - public NetMutex upgradeMutex = new NetMutex();
- - public NetPoint tilePosition = new NetPoint();
- - public Texture2D texture;
- - public NetRectangle upgradeRect = new NetRectangle();
- - public List<Parrot> parrots = new List<Parrot>();
- - public NetEvent0 upgradeCompleteEvent = new NetEvent0();
- - public NetEnum<UpgradeState> currentState = new NetEnum<UpgradeState>(UpgradeState.Idle);
- - public float stateTimer;
- - public NetInt requiredNuts = new NetInt(0);
- - public float squawkTime;
- - public float timeUntilChomp;
- - public float timeUntilSqwawk;
- - public float shakeTime;
- - public float costShakeTime;
- - public const int PARROT_COUNT = 24;
- - public bool parrotPresent = true;
- - public bool isPlayerNearby;
- - public NetString upgradeName = new NetString("");
- - public NetString requiredMail = new NetString("");
- - public float nextParrotSpawn;
- - public NetLocationRef locationRef = new NetLocationRef();
- - public Action onApplyUpgrade;
- - public Func<bool> onUpdateCompletionStatus;
- - public NetFields NetFields { get; } = new NetFields("ParrotUpgradePerch");
- - public ParrotUpgradePerch()
- - public virtual void UpdateCompletionStatus()
- - public virtual void InitNetFields()
- - public virtual void PerformCompleteAnimation()
- - public ParrotUpgradePerch(GameLocation location, Point tile_position, Rectangle upgrade_rectangle, int required_nuts, Action apply_upgrade, Func<bool> update_completion_status, string upgrade_name = "", string required_mail = "")
- - public bool IsAtTile(int x, int y)
- - public virtual void PerformAnimation()
- - public virtual bool IsAvailable(bool use_cached_value = false)
- - public virtual void StartAnimation()
- - public bool CheckAction(Location tile_location, Farmer farmer)
- - public virtual bool AnswerQuestion(Response answer)
- - public static void ActivateGoldenParrot()
- - public virtual void AttemptConstruction()
- - public virtual void ShowInsufficientNuts()
- - public virtual void ApplyUpgrade()
- - public virtual void Cleanup()
- - public virtual void ResetForPlayerEntry()
- - public void resetCache()
- - public virtual void UpdateEvenIfFarmerIsntHere(GameTime time)
- - public virtual void Update(GameTime time)
- - public virtual void Draw(SpriteBatch b)
- - public virtual void DrawAboveAlwaysFrontLayer(SpriteBatch b)

## Private Members
- - private int baseFrame;
- - private int birdType;
- - private int flapFrame;
- - private float nextFlapTime;
- - private bool soundBird;
- - private float EaseInOutQuad(float t, float b, float c, float d)
- - private float EaseInQuad(float t, float b, float c, float d)

## Protected Members
- - protected ParrotUpgradePerch _perch;
- - protected Vector2 targetPosition = Vector2.Zero;
- - protected Vector2 startPosition = Vector2.Zero;
- - protected bool _cachedAvailablity;

## Internal Members
- *(None)*

## Other Members
- *(None)*
