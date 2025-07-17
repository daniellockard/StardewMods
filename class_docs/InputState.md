# InputState

**Summary:** Handles player input or controls.

## Public Members
- - public virtual void UpdateStates()
- - public virtual void Update()
- - public virtual void IgnoreKeys(Keys[] keys)
- - public virtual KeyboardState GetKeyboardState()
- - public virtual GamePadState GetGamePadState()
- - public virtual MouseState GetMouseState()
- - public virtual void SetMousePosition(int x, int y)
- - public interface ISalable : IHaveItemTypeId

## Private Members
- *(None)*

## Protected Members
- - protected Point _simulatedMousePosition = Point.Zero;
- - protected List<Keys> _ignoredKeys = new List<Keys>();
- - protected List<Keys> _pressedKeys = new List<Keys>();
- - protected KeyboardState? _keyState;
- - protected int _lastKeyStateTick = -1;
- - protected KeyboardState _currentKeyboardState;
- - protected MouseState _currentMouseState;
- - protected GamePadState _currentGamepadState;

## Internal Members
- *(None)*

## Other Members
- *(None)*
