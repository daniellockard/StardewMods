# SoundBankWrapper

**Summary:** Handles game audio or sound effects.

## Public Members
- - public bool IsInUse => soundBank.IsInUse;
- - public bool IsDisposed => soundBank.IsDisposed;
- - public SoundBankWrapper(SoundBank soundBank)
- - public ICue GetCue(string name)
- - public void PlayCue(string name)
- - public void PlayCue(string name, AudioListener listener, AudioEmitter emitter)
- - public void Dispose()
- - public void AddCue(CueDefinition definition)
- - public bool Exists(string name)
- - public CueDefinition GetCueDefinition(string name)

## Private Members
- - private string DefaultCueName = "shiny4";
- - private SoundBank soundBank;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
