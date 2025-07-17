# DebugTimings

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool Toggle()
- - public void StartDrawTimer()
- - public void StopDrawTimer()
- - public void StartUpdateTimer()
- - public void StopUpdateTimer()
- - public void Draw()

## Private Members
- - private static readonly Vector2 DrawPos = Vector2.One * 12f;
- - private readonly Stopwatch StopwatchDraw = new Stopwatch();
- - private readonly Stopwatch StopwatchUpdate = new Stopwatch();
- - private double LastTimingDraw;
- - private double LastTimingUpdate;
- - private float DrawTextWidth = -1f;
- - private bool Active;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
