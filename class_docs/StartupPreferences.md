# StartupPreferences

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int windowed_borderless = 0;
- - public const int windowed = 1;
- - public const int fullscreen = 2;
- - public static XmlSerializer serializer = null;
- - public bool startMuted;
- - public bool levelTenFishing;
- - public bool levelTenMining;
- - public bool levelTenForaging;
- - public bool levelTenCombat;
- - public bool skipWindowPreparation;
- - public bool sawAdvancedCharacterCreationIndicator;
- - public int timesPlayed;
- - public int windowMode;
- - public int displayIndex = -1;
- - public Options.GamepadModes gamepadMode;
- - public int playerLimit = -1;
- - public int fullscreenResolutionX;
- - public int fullscreenResolutionY;
- - public string lastEnteredIP = "";
- - public string languageCode;
- - public Options clientOptions = new Options();
- - public bool isLoaded;
- - public bool IsBusy
- - public void OnLanguageChange(LocalizedContentManager.LanguageCode code)
- - public void savePreferences(bool async, bool update_language_from_ingame_language = false)
- - public void loadPreferences(bool async, bool applyLanguage)

## Private Members
- - private static readonly string _filename = "startup_preferences";
- - private bool _isBusy;
- - private bool _pendingApplyLanguage;
- - private Task _task;
- - private void Init()
- - private void ensureFolderStructureExists()
- - private void _savePreferences()
- - private long writeSettings(Stream stream)
- - private void _loadPreferences()
- - private void readSettings(Stream stream)

## Protected Members
- - protected virtual void _SetLanguageFromCode(string language_code_string)

## Internal Members
- *(None)*

## Other Members
- *(None)*
