# CueWrapper

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool IsStopped => cue.IsStopped;
- - public bool IsStopping => cue.IsStopping;
- - public bool IsPlaying => cue.IsPlaying;
- - public bool IsPaused => cue.IsPaused;
- - public string Name => cue.Name;
- - public float Volume
- - public float Pitch
- - public bool IsPitchBeingControlledByRPC => cue.IsPitchBeingControlledByRPC;
- - public CueWrapper(Cue cue)
- - public void Play()
- - public void Pause()
- - public void Resume()
- - public void Stop(AudioStopOptions options)
- - public void SetVariable(string var, int val)
- - public void SetVariable(string var, float val)
- - public float GetVariable(string var)
- - public void Dispose()

## Private Members
- - private Cue cue;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
