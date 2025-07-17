# SteamHelper

**Summary:** Utility or helper class.

## Public Members
- - public bool active;
- - public SDKNetHelper Networking => networking;
- - public bool ConnectionFinished { get; private set; }
- - public int ConnectionProgress { get; private set; }
- - public bool GalaxyConnected { get; private set; }
- - public string Name { get; } = "Steam";
- - public bool HasOverlay => false;
- - public bool IsJapaneseRegionRelease => false;
- - public bool IsEnterButtonAssignmentFlipped => false;
- - public void EarlyInitialize()
- - public virtual bool IsRunningOnSteamDeck()
- - public void Initialize()
- - public void CancelKeyboard()
- - public void ShowKeyboard(TextBox text_box)
- - public void OnKeyboardDismissed(GamepadTextInputDismissed_t callback)
- - public bool RetroactiveAchievementsAllowed()
- - public void GetAchievement(string achieve)
- - public void ResetAchievements()
- - public void Update()
- - public void Shutdown()
- - public void DebugInfo()
- - public string FilterDirtyWords(string words)

## Private Members
- - private Callback<GameOverlayActivated_t> gameOverlayActivated;
- - private CallResult<EncryptedAppTicketResponse_t> encryptedAppTicketResponse;
- - private Callback<GamepadTextInputDismissed_t> gamepadTextInputDismissed;
- - private GalaxyAuthListener galaxyAuthListener;
- - private GalaxyOperationalStateChangeListener galaxyStateChangeListener;
- - private GalaxySpecificUserDataListener galaxySpecificUserDataListener;
- - private SDKNetHelper networking;
- - private TextBox _keyboardTextBox;
- - private void onSetGalaxyProfileName(GalaxyID userID)
- - private void onGalaxyStateChange(uint operationalState)
- - private void onGalaxyAuthSuccess()
- - private unsafe void onGalaxyAuthFailure(FailureReason reason)
- - private void onGalaxyAuthLost()
- - private unsafe void onEncryptedAppTicketResponse(EncryptedAppTicketResponse_t response, bool ioFailure)
- - private void onGameOverlayActivated(GameOverlayActivated_t pCallback)

## Protected Members
- - protected bool _runningOnSteamDeck;

## Internal Members
- *(None)*

## Other Members
- *(None)*
