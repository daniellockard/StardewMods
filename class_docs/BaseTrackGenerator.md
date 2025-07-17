# BaseTrackGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int OBSTACLE_NONE = -10;
- - public const int OBSTACLE_MIDDLE = -10;
- - public const int OBSTACLE_FRONT = -11;
- - public const int OBSTACLE_BACK = -12;
- - public const int OBSTACLE_RANDOM = -13;
- - public static bool FlatsOnly(Track track, BaseTrackGenerator generator)
- - public static bool UpSlopesOnly(Track track, BaseTrackGenerator generator)
- - public static bool DownSlopesOnly(Track track, BaseTrackGenerator generator)
- - public static bool IceDownSlopesOnly(Track track, BaseTrackGenerator generator)
- - public static bool Always(Track track, BaseTrackGenerator generator)
- - public static bool EveryOtherTile(Track track, BaseTrackGenerator generator)
- - public T AddObstacle<T>(ObstacleTypes obstacle_type, int position, float obstacle_chance = 1f) where T : BaseTrackGenerator
- - public T AddPickupFunction<T>(Func<Track, BaseTrackGenerator, bool> pickup_spawn_function) where T : BaseTrackGenerator
- - public BaseTrackGenerator(MineCart game)
- - public Track AddTrack(int x, int y, Track.TrackType track_type = Track.TrackType.Straight)
- - public Track AddTrack(Track track)
- - public Track AddPickupTrack(int x, int y, Track.TrackType track_type = Track.TrackType.Straight)
- - public virtual void Initialize()
- - public void GenerateTrack()
- - public void PopulateObstacles()

## Private Members
- *(None)*

## Protected Members
- - protected List<Track> _generatedTracks;
- - protected MineCart _game;
- - protected Dictionary<int, KeyValuePair<ObstacleTypes, float>> _obstacleIndices = new Dictionary<int, KeyValuePair<ObstacleTypes, float>>();
- - protected Func<Track, BaseTrackGenerator, bool> _pickupFunction;
- - protected virtual void _GenerateTrack()

## Internal Members
- *(None)*

## Other Members
- *(None)*
