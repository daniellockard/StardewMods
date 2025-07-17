# GalaxyHelper

**Summary:** Utility or helper class.

## Public Members
- - public const string ClientID = "48767653913349277";
- - public const string ClientSecret = "58be5c2e55d7f535cf8c4b6bbc09d185de90b152c8c42703cc13502465f0d04a";
- - public const string DisplayNameDataKey = "StardewDisplayName";
- - public bool active;
- - public string Name { get; } = "Galaxy";
- - public bool ConnectionFinished { get; private set; }
- - public int ConnectionProgress { get; private set; }
- - public SDKNetHelper Networking => networking;
- - public bool HasOverlay => false;
- - public bool IsJapaneseRegionRelease => false;
- - public bool IsEnterButtonAssignmentFlipped => false;
- - public void EarlyInitialize()
- - public void Initialize()
- - public bool RetroactiveAchievementsAllowed()
- - public void GetAchievement(string achieve)
- - public void ResetAchievements()
- - public void Update()
- - public void Shutdown()
- - public void DebugInfo()
- - public string FilterDirtyWords(string words)

## Private Members
- - private GalaxyAuthListener authListener;
- - private GalaxyOperationalStateChangeListener stateChangeListener;
- - private GalaxyNetHelper networking;
- - private void onGalaxyStateChange(uint operationalState)
- - private void onGalaxyAuthSuccess()
- - private unsafe void onGalaxyAuthFailure(FailureReason reason)
- - private void onGalaxyAuthLost()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
