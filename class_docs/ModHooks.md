# ModHooks

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public virtual void OnGame1_PerformTenMinuteClockUpdate(Action action)
- - public virtual void OnGame1_NewDayAfterFade(Action action)
- - public virtual void OnGame1_ShowEndOfNightStuff(Action action)
- - public virtual void OnGame1_UpdateControlInput(ref KeyboardState keyboardState, ref MouseState mouseState, ref GamePadState gamePadState, Action action)
- - public virtual void OnGameLocation_ResetForPlayerEntry(GameLocation location, Action action)
- - public virtual bool OnGameLocation_CheckAction(GameLocation location, Location tileLocation, Rectangle viewport, Farmer who, Func<bool> action)
- - public virtual FarmEvent OnUtility_PickFarmEvent(Func<FarmEvent> action)
- - public virtual void AfterNewDayBarrier(string barrier_id)
- - public virtual void CreatedInitialLocations()
- - public virtual void SaveAddedLocations()
- - public virtual bool OnRendering(RenderSteps step, SpriteBatch sb, GameTime time, RenderTarget2D target_screen)
- - public virtual void OnRendered(RenderSteps step, SpriteBatch sb, GameTime time, RenderTarget2D target_screen)
- - public virtual bool TryDrawMenu(IClickableMenu menu, Action draw_menu_action)
- - public virtual Task StartTask(Task task, string id)
- - public virtual Task<T> StartTask<T>(Task<T> task, string id)
- - public enum RenderSteps

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
