# DummyAudioEngine

**Summary:** Handles game audio or sound effects.

## Public Members
- - public AudioEngine Engine { get; }
- - public bool IsDisposed { get; } = true;
- - public void Update()
- - public IAudioCategory GetCategory(string name)
- - public int GetCategoryIndex(string name)
- - public void Dispose()
- - public interface IAudioCategory
- - public interface IAudioEngine : IDisposable
- - public interface ISoundsHelper

## Private Members
- - private IAudioCategory category = new DummyAudioCategory();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
