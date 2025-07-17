# AmbientLocationSounds

**Summary:** Represents a place or area in the game world.

## Public Members
- - public const int sound_babblingBrook = 0;
- - public const int sound_cracklingFire = 1;
- - public const int sound_engine = 2;
- - public const int sound_cricket = 3;
- - public const int sound_waterfall = 4;
- - public const int sound_waterfall_big = 5;
- - public const int numberOfSounds = 6;
- - public const float doNotPlay = 9999999f;
- - public static void InitShared()
- - public static void update(GameTime time)
- - public static void changeSpecificVariable(string variableName, float value, int whichSound)
- - public static void addSound(Vector2 tileLocation, int whichSound)
- - public static void removeSound(Vector2 tileLocation)
- - public static void onLocationLeave()

## Private Members
- - private static Dictionary<Vector2, int> sounds = new Dictionary<Vector2, int>();
- - private static int updateTimer = 100;
- - private static int farthestSoundDistance = 1024;
- - private static float[] shortestDistanceForCue;
- - private static ICue babblingBrook;
- - private static ICue cracklingFire;
- - private static ICue engine;
- - private static ICue cricket;
- - private static ICue waterfall;
- - private static ICue waterfallBig;
- - private static float volumeOverrideForLocChange;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
