# SoundsHelper

**Summary:** Handles game audio or sound effects.

## Public Members
- - public const float DefaultPitch = 1200f;
- - public const float MaxPitch = 2400f;
- - public static int MaxDistanceFromScreen = 12;
- - public virtual bool LogSounds
- - public virtual bool ShouldPlayLocal(SoundContext context)
- - public virtual float GetVolumeForDistance(GameLocation location, Vector2? position)
- - public virtual bool PlayLocal(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context, out ICue cue)
- - public virtual void PlayAll(string cueName, GameLocation location, Vector2? position, int? pitch, SoundContext context)
- - public void SetPitch(ICue cue, float pitch, bool forcePitch = true)
- - public virtual bool CanSkipSoundSync(GameLocation location, Vector2? position, SoundContext context)

## Private Members
- - private Action<string, GameLocation, Vector2?, int?, float, SoundContext, string> LogSound;

## Protected Members
- - protected virtual void LogSoundImpl(string cueName, GameLocation location, Vector2? position, int? pitch, float volume, SoundContext context, string skipReason = null)

## Internal Members
- *(None)*

## Other Members
- *(None)*
