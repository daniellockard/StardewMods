# DummySoundBank

**Summary:** Handles game audio or sound effects.

## Public Members
- - public bool IsInUse => false;
- - public bool IsDisposed => true;
- - public bool Exists(string name)
- - public ICue GetCue(string name)
- - public void PlayCue(string name)
- - public void PlayCue(string name, AudioListener listener, AudioEmitter emitter)
- - public void AddCue(CueDefinition definition)
- - public CueDefinition GetCueDefinition(string name)
- - public void Dispose()
- - public enum StackDrawType

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- - internal static readonly ICue DummyCue = new DummyCue();

## Other Members
- *(None)*
