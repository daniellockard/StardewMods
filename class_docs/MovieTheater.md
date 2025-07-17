# MovieTheater

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum MovieStates
- - public readonly NetInt dayFirstEntered = new NetInt(-1);
- - public const int LOVE_MOVIE_FRIENDSHIP = 200;
- - public const int LIKE_MOVIE_FRIENDSHIP = 100;
- - public const int DISLIKE_MOVIE_FRIENDSHIP = 0;
- - public const int LOVE_CONCESSION_FRIENDSHIP = 50;
- - public const int LIKE_CONCESSION_FRIENDSHIP = 25;
- - public const int DISLIKE_CONCESSION_FRIENDSHIP = 0;
- - public const int OPEN_TIME = 900;
- - public const int CLOSE_TIME = 2100;
- - public const string MainTileSheetId = "movieTheater_tileSheet";
- - public PerchingBirds birds;
- - public static string forceMovieId;
- - public static string[][][][] possibleNPCGroups = new string[7][][][]
- - public MovieTheater()
- - public static void AddMoviePoster(GameLocation location, float x, float y, bool isUpcoming = false)
- - public MovieTheater(string map, string name)
- - public static List<MovieCharacterReaction> GetMovieReactions()
- - public static string GetConcessionTasteForCharacter(Character character, MovieConcession concession)
- - public static IEnumerable<string> GetPatronNames()
- - public void OnStartMovieEvent(StartMovieEvent e)
- - public void OnRequestStartMovieEvent(long uid)
- - public void OnMovieViewerLockEvent(MovieViewerLockEvent e)
- - public void _ShowMovieStartReady()
- - public static List<MovieData> GetMovieData()
- - public static Dictionary<string, MovieData> GetMovieDataById()
- - public static bool TryGetMovieData(string id, out MovieData data)
- - public static string GetMovieIdFromLegacyIndex(string id)
- - public static Rectangle GetSourceRectForScreen(int movieIndex, int frame)
- - public static Rectangle GetSourceRectForPoster(int movieIndex)
- - public NPC GetMoviePatron(string name)
- - public void RemoveAllPatrons()
- - public static MovieData GetMovieToday()
- - public static List<MovieData> GetMoviesForSeason(WorldDate date)
- - public static MovieData GetMovieForDate(WorldDate date)
- - public static MovieData GetUpcomingMovie()
- - public static MovieData GetUpcomingMovieForDate(WorldDate afterDate)
- - public static bool MovieYearMatches(MovieData movie, int year)
- - public static bool MovieSeasonMatches(MovieData movie, Season season)
- - public override void DayUpdate(int dayOfMonth)
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
- - public static bool Invite(Farmer farmer, NPC invited_npc)
- - public void ResetTheater()
- - public override void updateEvenIfFarmerIsntHere(GameTime time, bool ignoreWasUpdatedFlush = false)
- - public static MovieCharacterReaction GetReactionsForCharacter(NPC character)
- - public override void checkForMusic(GameTime time)
- - public static string GetResponseForMovie(NPC character)
- - public Dialogue GetDialogueForCharacter(NPC character)
- - public string FormatString(string text, params string[] args)
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public Dictionary<Character, MovieConcession> GetConcessionsDictionary()
- - public override void cleanupBeforePlayerExit()
- - public void RequestEndMovie(long uid)
- - public void PathCharacterToLocation(NPC character, Point point, int direction)
- - public static Dictionary<string, MovieConcession> GetConcessions()
- - public static MovieConcession GetConcessionItem(string id)
- - public bool OnPurchaseConcession(ISalable salable, Farmer who, int countTaken, ItemStockInformation stock)
- - public bool HasInvitedSomeone(Farmer who)
- - public bool HasPurchasedConcession(Farmer who)
- - public static Farmer GetFirstInvitedPlayer(NPC npc)
- - public override void performTouchAction(string[] action, Vector2 playerStandingPosition)
- - public static List<MovieConcession> GetConcessionsForGuest()
- - public static List<MovieConcession> GetConcessionsForGuest(string npc_name)
- - public override bool answerDialogueAction(string questionAndAnswer, string[] questionParams)
- - public override bool performAction(string[] action, Farmer who, Location tileLocation)
- - public static void ClearCachedLocalizedData()
- - public static void ClearCachedConcessionTastes()

## Private Members
- - private NetEvent1<MovieViewerLockEvent> movieViewerLockEvent = new NetEvent1<MovieViewerLockEvent>();
- - private NetEvent1<StartMovieEvent> startMovieEvent = new NetEvent1<StartMovieEvent>();
- - private NetEvent1Field<long, NetLong> requestStartMovieEvent = new NetEvent1Field<long, NetLong>();
- - private NetEvent1Field<long, NetLong> endMovieEvent = new NetEvent1Field<long, NetLong>();
- - private void addRandomNPCs()
- - private void addSpecificRandomNPC(int whichRandomNPC)
- - private void tryToStartCraneGame(Farmer who, string whichAnswer)

## Protected Members
- - protected bool _startedMovie;
- - protected static bool _isJojaTheater = false;
- - protected static List<MovieData> _movieData;
- - protected static Dictionary<string, MovieData> _movieDataById;
- - protected static List<MovieCharacterReaction> _genericReactions;
- - protected static List<ConcessionTaste> _concessionTastes;
- - protected readonly NetStringDictionary<int, NetInt> _spawnedMoviePatrons = new NetStringDictionary<int, NetInt>();
- - protected readonly NetStringDictionary<string, NetString> _purchasedConcessions = new NetStringDictionary<string, NetString>();
- - protected readonly NetStringDictionary<int, NetInt> _playerInvitedPatrons = new NetStringDictionary<int, NetInt>();
- - protected readonly NetStringDictionary<bool, NetBool> _characterGroupLookup = new NetStringDictionary<bool, NetBool>();
- - protected Dictionary<int, List<Point>> _hangoutPoints;
- - protected Dictionary<int, List<Point>> _availableHangoutPoints;
- - protected int _maxHangoutGroups;
- - protected int _movieStartTime = -1;
- - protected static Dictionary<string, MovieConcession> _concessions;
- - protected Dictionary<string, KeyValuePair<Point, int>> _destinationPositions = new Dictionary<string, KeyValuePair<Point, int>>();
- - protected int _exitX;
- - protected int _exitY;
- - protected List<Farmer> _viewingFarmers = new List<Farmer>();
- - protected List<List<Character>> _viewingGroups = new List<List<Character>>();
- - protected List<List<Character>> _playerGroups = new List<List<Character>>();
- - protected List<List<Character>> _npcGroups = new List<List<Character>>();
- - protected static bool _hasRequestedMovieStart = false;
- - protected static int _playerHangoutGroup = -1;
- - protected int _farmerCount;
- - protected readonly NetInt currentState = new NetInt();
- - protected readonly NetInt showingId = new NetInt();
- - protected int CurrentState
- - protected int ShowingId
- - protected void _InitializeMap()
- - protected override void initNetFields()
- - protected NPC AddMoviePatronNPC(string name, int x, int y, int facingDirection)
- - protected override void resetSharedState()
- - protected override void resetLocalState()
- - protected void _PopulateNPCOnlyGroups(List<List<Character>> player_groups, List<List<Character>> groups)
- - protected void _ResetHangoutPoints()
- - protected void _Leave()

## Internal Members
- *(None)*

## Other Members
- *(None)*
