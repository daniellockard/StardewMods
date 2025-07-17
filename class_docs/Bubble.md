# Bubble

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 _normalizedVelocity;
- - public float moveSpeed = 8f;
- - public Vector2 bubbleOffset = Vector2.Zero;
- - public override void OnPlayerReset()
- - public override Rectangle GetBounds()
- - public Bubble(float angle, float speed)
- - public override bool OnBump(PlayerMineCartCharacter player)
- - public override bool OnBounce(MineCartCharacter player)
- - public void Pop(bool play_sound = true)
- - public override void _Draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected float _age;
- - protected int _currentFrame;
- - protected float _timePerFrame = 0.5f;
- - protected int[] _frames = new int[6] { 0, 1, 2, 3, 3, 2 };
- - protected int _repeatedFrameCount = 4;
- - protected float _lifeTime = 3f;
- - protected override void _Update(float time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
