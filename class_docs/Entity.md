# Entity

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 position;
- - public bool visible = true;
- - public bool enabled = true;
- - public Vector2 drawnPosition => position - new Vector2(_game.screenLeftBound, 0f);
- - public virtual void OnPlayerReset()
- - public bool IsOnScreen()
- - public bool IsActive()
- - public void Initialize(MineCart game)
- - public void Destroy()
- - public virtual bool ShouldReap()
- - public void Draw(SpriteBatch b)
- - public virtual void _Draw(SpriteBatch b)
- - public void Update(float time)

## Private Members
- *(None)*

## Protected Members
- - protected MineCart _game;
- - protected bool _destroyed;
- - protected virtual void _Initialize()
- - protected virtual void _Update(float time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
