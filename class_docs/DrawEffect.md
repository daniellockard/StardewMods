# DrawEffect

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public virtual bool Apply(ref Vector2 position, ref float rotation, ref Vector2 scale)
- - public int gameWidth = 304;
- - public int gameHeight = 150;
- - public Texture2D spriteSheet;
- - public Vector2 upperLeft;
- - public Action onQuit;
- - public ICue music;
- - public ICue fastMusic;
- - public Effect _effect;
- - public int freezeFrames;
- - public ICue craneSound;
- - public List<Type> _gameObjectTypes;
- - public Dictionary<Type, List<CraneGameObject>> _gameObjectsByType;
- - public CraneGame()
- - public void Quit()
- - public bool IsButtonPressed(GameButtons button)
- - public bool IsButtonDown(GameButtons button)
- - public T GetObjectAtPoint<T>(Vector2 point, int max_count = -1) where T : CraneGameObject
- - public List<T> GetObjectsAtPoint<T>(Vector2 point, int max_count = -1) where T : CraneGameObject
- - public T GetObjectOfType<T>() where T : CraneGameObject
- - public List<T> GetObjectsOfType<T>() where T : CraneGameObject
- - public List<T> GetOverlaps<T>(CraneGameObject target, int max_count = -1) where T : CraneGameObject
- - public bool tick(GameTime time)
- - public bool forceQuit()
- - public bool overrideFreeMouseMovement()
- - public bool doMainGameUpdates()
- - public void receiveLeftClick(int x, int y, bool playSound = true)
- - public void leftClickHeld(int x, int y)
- - public void receiveRightClick(int x, int y, bool playSound = true)
- - public void releaseLeftClick(int x, int y)
- - public void releaseRightClick(int x, int y)
- - public void receiveKeyPress(Keys k)
- - public void receiveKeyRelease(Keys k)
- - public void RegisterGameObject(CraneGameObject game_object)
- - public void UnregisterGameObject(CraneGameObject game_object)
- - public void draw(SpriteBatch b)
- - public void changeScreenSize()
- - public void unload()
- - public void receiveEventPoke(int data)
- - public string minigameId()

## Private Members
- *(None)*

## Protected Members
- - protected LocalizedContentManager _content;
- - protected List<CraneGameObject> _gameObjects;
- - protected Dictionary<GameButtons, int> _buttonStates;
- - protected bool _shouldQuit;
- - protected void _UpdateInput()
- - protected void _UpdateButtonState(GameButtons button, InputButton[] keys, HashSet<InputButton> emulated_keys)

## Internal Members
- *(None)*

## Other Members
- *(None)*
