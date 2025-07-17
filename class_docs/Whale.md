# Whale

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum CurrentState
- - public float mouthCloseTime = 1f;
- - public void SetState(CurrentState new_state, float state_timer = 1f)
- - public override void OnPlayerReset()
- - public override void _Draw(SpriteBatch b)

## Private Members
- *(None)*

## Protected Members
- - protected CurrentState _currentState;
- - protected float _stateTimer;
- - protected float _nextFire;
- - protected int _currentFrame;
- - protected Vector2 _basePosition;
- - protected override void _Update(float time)
- - protected override void _Initialize()

## Internal Members
- *(None)*

## Other Members
- *(None)*
