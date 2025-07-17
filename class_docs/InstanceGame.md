# InstanceGame

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public object staticVarHolder;
- - public bool IsMainInstance
- - public GraphicsDevice GraphicsDevice => ((Game)GameRunner.instance).GraphicsDevice;
- - public ContentManager Content => ((Game)GameRunner.instance).Content;
- - public GameComponentCollection Components => ((Game)GameRunner.instance).Components;
- - public GameWindow Window => ((Game)GameRunner.instance).Window;
- - public bool IsFixedTimeStep
- - public bool IsActive => ((Game)GameRunner.instance).IsActive;
- - public bool IsMouseVisible
- - public TimeSpan TargetElapsedTime
- - public void Exit()

## Private Members
- *(None)*

## Protected Members
- - protected virtual void Initialize()
- - protected virtual void LoadContent()
- - protected virtual void UnloadContent()
- - protected virtual void Update(GameTime game_time)
- - protected virtual void OnActivated(object sender, EventArgs args)
- - protected virtual void Draw(GameTime game_time)
- - protected virtual void BeginDraw()
- - protected virtual void EndDraw()

## Internal Members
- *(None)*

## Other Members
- *(None)*
