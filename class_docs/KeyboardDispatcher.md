# KeyboardDispatcher

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public IKeyboardSubscriber Subscriber
- - public void Cleanup()
- - public KeyboardDispatcher(GameWindow window)
- - public bool ShouldSuppress()
- - public void Discard()
- - public void Poll()

## Private Members
- - private IKeyboardSubscriber _subscriber;
- - private string _pasteResult = "";
- - private void Event_KeyDown(object sender, Keys key)
- - private void Event_TextInput(object sender, TextInputEventArgs e)
- - private void EventInput_KeyDown(object sender, KeyEventArgs e)
- - private void EventInput_CharEntered(object sender, CharacterEventArgs e)
- - private void PasteThread()

## Protected Members
- - protected string _enteredText;
- - protected List<char> _commandInputs = new List<char>();
- - protected List<Keys> _keysDown = new List<Keys>();
- - protected List<char> _charsEntered = new List<char>();
- - protected GameWindow _window;
- - protected KeyboardState _oldKeyboardState;

## Internal Members
- *(None)*

## Other Members
- *(None)*
