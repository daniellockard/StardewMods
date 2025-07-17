# MineDebris

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public float ySinWaveMagnitude;
- - public float flipRate;
- - public float depth = 0.45f;
- - public MineDebris(Rectangle source_rect, Vector2 spawn_position, float dx, float dy, float flip_rate = 0f, float gravity_multiplier = 1f, float life_time = 0.5f, float scale = 1f, int num_animation_frames = 1, float animation_interval = 0.1f, float draw_depth = 0.45f, bool holdLastFrame = false, float timeBeforeDisplay = 0f)
- - public void reset(Rectangle source_rect, Vector2 spawn_position, float dx, float dy, float flip_rate = 0f, float gravity_multiplier = 1f, float life_time = 0.5f, float scale = 1f, int num_animation_frames = 1, float animation_interval = 0.1f, float draw_depth = 0.45f, bool holdLastFrame = false, float timeBeforeDisplay = 0f)
- - public void SetColor(Color color)
- - public void SetDestroySound(string sound)
- - public void SetStartSound(string sound)
- - public override void _Draw(SpriteBatch b)

## Private Members
- - private float timeBeforeDisplay;
- - private string destroySound;
- - private string startSound;
- - private Rectangle _GetSourceRect()

## Protected Members
- - protected Rectangle _sourceRect;
- - protected float _dX;
- - protected float _dY;
- - protected float _age;
- - protected float _lifeTime;
- - protected float _gravityMultiplier;
- - protected float _scale = 1f;
- - protected Color _color = Color.White;
- - protected int _numAnimationFrames;
- - protected bool _holdLastFrame;
- - protected float _animationInterval;
- - protected int _currentAnimationFrame;
- - protected float _animationTimer;
- - protected override void _Update(float time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
