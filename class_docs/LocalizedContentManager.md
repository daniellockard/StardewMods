# LocalizedContentManager

**Summary:** Handles or manages a specific system or feature.

## Public Members
- - public delegate void LanguageChangedHandler(LanguageCode code);
- - public enum LanguageCode
- - public static readonly Dictionary<string, string> localizedAssetNames = new Dictionary<string, string>();
- - public CultureInfo CurrentCulture;
- - public static string CurrentLanguageString
- - public static LanguageCode CurrentLanguageCode
- - public static bool CurrentLanguageLatin
- - public static ModLanguage CurrentModLanguage => _currentModLanguage;
- - public static event LanguageChangedHandler OnLanguageChange;
- - public static LanguageCode GetDefaultLanguageCode()
- - public LocalizedContentManager(IServiceProvider serviceProvider, string rootDirectory, CultureInfo currentCulture)
- - public LocalizedContentManager(IServiceProvider serviceProvider, string rootDirectory)
- - public static StringBuilder FormatTimeString(int time, string format)
- - public static void SetModLanguage(ModLanguage new_mod_language)
- - public virtual string GetContentRoot()
- - public virtual bool DoesAssetExist<T>(string assetName)
- - public virtual T LoadImpl<T>(string baseAssetName, string localizedAssetName, LanguageCode languageCode)
- - public override T Load<T>(string assetName)
- - public virtual T Load<T>(string assetName, LanguageCode language)
- - public static string LanguageCodeString(LanguageCode code)
- - public LanguageCode GetCurrentLanguage()
- - public virtual bool IsValidTranslationKey(string path)
- - public virtual string LoadStringReturnNullIfNotFound(string path, bool localeFallback = true)
- - public virtual string LoadStringReturnNullIfNotFound(string path, string sub1, bool localeFallback = true)
- - public virtual string LoadStringReturnNullIfNotFound(string path, string sub1, string sub2, bool localeFallback = true)
- - public virtual string LoadStringReturnNullIfNotFound(string path, object[] substitutions, bool localeFallback = true)
- - public virtual string LoadString(string path)
- - public virtual string PreprocessString(string text)
- - public virtual bool ShouldUseGenderedCharacterTranslations()
- - public virtual string LoadString(string path, object sub1)
- - public virtual string LoadString(string path, object sub1, object sub2)
- - public virtual string LoadString(string path, object sub1, object sub2, object sub3)
- - public virtual string LoadString(string path, params object[] substitutions)
- - public virtual string LoadBaseStringOrNull(string path)
- - public virtual string LoadBaseString(string path)
- - public virtual LocalizedContentManager CreateTemporary()

## Private Members
- - private const bool OnlyCheckManifest = true;
- - private static readonly object ManifestLocker = new object();
- - private static HashSet<string> _manifest = null;
- - private static LanguageCode _currentLangCode = GetDefaultLanguageCode();
- - private static string _currentLangString = null;
- - private static ModLanguage _currentModLanguage = null;
- - private void PlatformEnsureManifestInitialized()
- - private void EnsureManifestInitialized()
- - private string GetString(Dictionary<string, string> strings, string key)
- - private void parseStringPath(string path, out string assetName, out string key)

## Protected Members
- - protected string _CachedContentRoot;
- - protected static StringBuilder _timeFormatStringBuilder = new StringBuilder();
- - protected static bool _IsStringAt(string source, string string_to_find, int index)

## Internal Members
- *(None)*

## Other Members
- *(None)*
