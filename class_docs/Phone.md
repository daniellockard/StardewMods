# Phone

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public static List<IPhoneHandler> PhoneHandlers = new List<IPhoneHandler>
- - public const int RING_DURATION = 600;
- - public const int RING_CYCLE_TIME = 1800;
- - public static Random r;
- - public static int ringingTimer;
- - public static string whichPhoneCall = null;
- - public static long lastRunTick = -1L;
- - public static long lastMinutesElapsedTick = -1L;
- - public static int intervalsToRing = 0;
- - public override string TypeDefinitionId => "(BC)";
- - public Phone()
- - public Phone(Vector2 position)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public static bool HandleIncomingCall(string callId)
- - public override void updateWhenCurrentLocation(GameTime time)
- - public override void DayUpdate()
- - public override bool minutesElapsed(int minutes)
- - public static bool IsRinging()
- - public static void Ring(string callId)
- - public static void StopRinging()
- - public static void HangUp()
- - public static Action GetIncomingCallAction(string callId)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- *(None)*

## Protected Members
- - protected static bool _phoneSoundPlaying = false;

## Internal Members
- *(None)*

## Other Members
- *(None)*
