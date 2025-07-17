# ScreenFade

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool globalFade;
- - public bool fadeIn = true;
- - public bool fadeToBlack;
- - public bool nonWarpFade;
- - public float fadeToBlackAlpha;
- - public float globalFadeSpeed;
- - public ScreenFade(Func<bool> onFadeToBlack, Action onFadeIn)
- - public bool UpdateFade(GameTime time)
- - public void UpdateFadeAlpha(GameTime time)
- - public void FadeScreenToBlack(float startAlpha = 0f, bool stopMovement = true)
- - public void FadeClear(float startAlpha = 1f)
- - public void GlobalFadeToBlack(Game1.afterFadeFunction afterFade = null, float fadeSpeed = 0.02f)
- - public void GlobalFadeToClear(Game1.afterFadeFunction afterFade = null, float fadeSpeed = 0.02f)
- - public void UpdateGlobalFade()

## Private Members
- - private const float fadeToFudge = 0.1f;
- - private Game1.afterFadeFunction afterFade;
- - private Func<bool> onFadeToBlackComplete;
- - private Action onFadedBackInComplete;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
