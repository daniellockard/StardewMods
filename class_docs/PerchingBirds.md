# PerchingBirds

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int BIRD_STARTLE_DISTANCE = 200;
- - public List<Bird> _birds = new List<Bird>();
- - public Dictionary<Point, Bird> _birdPointOccupancy;
- - public bool roosting;
- - public int peckDuration = 5;
- - public float birdSpeed = 5f;
- - public PerchingBirds(Texture2D bird_texture, int flap_frames, int width, int height, Vector2 origin, Point[] perch_locations, Point[] roost_locations)
- - public int GetBirdWidth()
- - public int GetBirdHeight()
- - public Vector2 GetBirdOrigin()
- - public Texture2D GetTexture()
- - public Point GetFreeBirdPoint(Bird bird = null, int clearance = 200)
- - public void ReserveBirdPoint(Bird bird, Point point)
- - public bool ShouldBirdsRoost()
- - public Point[] GetCurrentBirdLocationList()
- - public virtual void Update(GameTime time)
- - public virtual void Draw(SpriteBatch b)
- - public virtual void ResetLocalState()
- - public virtual void AddBird(int bird_type)

## Private Members
- *(None)*

## Protected Members
- - protected Point[] _birdLocations;
- - protected Point[] _birdRoostLocations;
- - protected Texture2D _birdSheet;
- - protected int _birdWidth;
- - protected int _birdHeight;
- - protected int _flapFrames = 2;
- - protected Vector2 _birdOrigin;

## Internal Members
- *(None)*

## Other Members
- *(None)*
