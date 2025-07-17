# HugeSlime

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Vector2 spriteScale = new Vector2(1f, 1f);
- - public override Rectangle GetLocalBounds()
- - public override void OnPlayerReset()
- - public override void _Draw(SpriteBatch b)
- - public override bool ShouldReap()

## Private Members
- - private bool _hasPeparedToJump;

## Protected Members
- - protected float _timeUntilHop = 30f;
- - protected float _yVelocity;
- - protected bool _grounded;
- - protected float _lastTrackY = 300f;
- - protected int _currentFrame;
- - protected Vector2 _desiredScale = new Vector2(1f, 1f);
- - protected float _scaleSpeed = 4f;
- - protected float _jumpStrength = -200f;
- - protected override void _Initialize()
- - protected override void _Update(float time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
