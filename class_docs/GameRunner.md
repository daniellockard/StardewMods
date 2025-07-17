# GameRunner

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static GameRunner instance;
- - public List<Game1> gameInstances = new List<Game1>();
- - public List<Game1> gameInstancesToRemove = new List<Game1>();
- - public Game1 gamePtr;
- - public bool shouldLoadContent;
- - public List<int> startButtonState = new List<int>();
- - public List<KeyValuePair<Game1, IEnumerator<int>>> activeNewDayProcesses = new List<KeyValuePair<Game1, IEnumerator<int>>>();
- - public int nextInstanceId;
- - public static int MaxTextureSize = 4096;
- - public GameRunner()
- - public void SubscribeClientSizeChange()
- - public void OnWindowSizeChange(object sender, EventArgs args)
- - public int GetNewInstanceID()
- - public bool WasWindowSizeChanged()
- - public int GetMaxSimultaneousPlayers()
- - public void InitializeMainInstance()
- - public virtual void ExecuteForInstances(Action<Game1> action)
- - public virtual void RemoveGameInstance(Game1 instance)
- - public virtual void AddGameInstance(PlayerIndex player_index)
- - public virtual Game1 CreateGameInstance(PlayerIndex player_index = (PlayerIndex)0, int index = 0)
- - public virtual void InvalidateStartPress(PlayerIndex index)
- - public virtual bool IsStartDown(PlayerIndex index)
- - public static void SaveInstance(InstanceGame instance, bool force = false)
- - public static void LoadInstance(InstanceGame instance, bool force = false)

## Private Members
- - private static void SetInstanceDefaults(InstanceGame instance)

## Protected Members
- - protected bool _initialized;
- - protected bool _windowSizeChanged;
- - protected override void OnActivated(object sender, EventArgs args)
- - protected override void Draw(GameTime gameTime)
- - protected override void Initialize()
- - protected override void LoadContent()
- - protected override void UnloadContent()
- - protected override void Update(GameTime gameTime)

## Internal Members
- *(None)*

## Other Members
- *(None)*
