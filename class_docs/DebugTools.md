# DebugTools

**Summary:** Represents a tool used by the player (hoe, axe, etc.).

## Public Members
- - public static DebugMetricsComponent _metrics;
- - public static string FormatDivider(string label = null)
- - public static void ValidateIsMainThread(bool req)
- - public static bool IsMainThread()
- - public static void Assert(bool expression, string failureMessage)
- - public static void GameConstructed(Game game)
- - public static void GameLoadContent(Game game)
- - public static void BeforeGameInitialize(Game game)
- - public static void BeforeGameUpdate(Game1 game, ref GameTime gameTime)
- - public static void BeforeGameDraw(Game1 game, ref GameTime time)

## Private Members
- - private static int _mainThreadId;
- - private const string CommentFormat = "#----------------------------------------------------------------------------#";
- - private static bool _noFpsCap;
- - private static void CheckInput(Game1 game)
- - private static void ApplyNoFpsCap(bool nocap)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
