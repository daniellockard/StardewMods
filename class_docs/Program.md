# Program

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum LogType
- - public const int build_steam = 0;
- - public const int build_gog = 1;
- - public const int build_rail = 2;
- - public const int build_gdk = 3;
- - public static bool GameTesterMode = false;
- - public static bool releaseBuild = true;
- - public static bool enableCheats = !releaseBuild;
- - public const int buildType = 0;
- - public static Game1 gamePtr;
- - public static bool handlingException;
- - public static bool hasTriedToPrintLog;
- - public static bool successfullyPrintedLog;
- - public static void Main(string[] args)
- - public static string GetLocalAppDataFolder(string subfolder = null, bool createIfMissing = true)
- - public static string GetAppDataFolder(string subfolder = null, bool createIfMissing = true)
- - public static string GetDebugLogPath()
- - public static string GetSavesFolder()
- - public static string WriteLog(LogType logType, string message, bool append = false)
- - public static void AppendDiagnostics(StringBuilder sb)
- - public static void handleException(object sender, UnhandledExceptionEventArgs args)

## Private Members
- - private static SDKHelper _sdk;

## Protected Members
- *(None)*

## Internal Members
- - internal static readonly INetCompression defaultCompression = new LZ4NetCompression();
- - internal static INetCompression netCompression = defaultCompression;
- - internal static SDKHelper sdk

## Other Members
- *(None)*
