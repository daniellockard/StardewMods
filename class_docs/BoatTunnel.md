# BoatTunnel

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum TunnelAnimationState
- - public Rectangle gateRect = new Rectangle(0, 120, 32, 40);
- - public const float GATE_SECONDS_PER_FRAME = 0.1f;
- - public const int GATE_FRAMES = 5;
- - public const int PLANK_MAX_OFFSET = 16;
- - public float _plankPosition;
- - public float _plankDirection;
- - public TunnelAnimationState animationState;
- - public int TicketPrice { get; set; } = 1000;
- - public BoatTunnel()
- - public BoatTunnel(string map, string name)
- - public override void cleanupBeforePlayerExit()
- - public virtual bool GateFinishedAnimating()
- - public virtual bool PlankFinishedAnimating()
- - public virtual void SetCurrentState(TunnelAnimationState animation_state)
- - public virtual void UpdateGateTileProperty()
- - public override bool checkAction(Location tileLocation, Rectangle viewport, Farmer who)
- - public override bool isActionableTile(int xTile, int yTile, Farmer who)
- - public override bool answerDialogue(Response answer)
- - public override bool shouldShadowBeDrawnAboveBuildingsLayer(Vector2 p)
- - public virtual void StartDeparture()
- - public override void UpdateWhenCurrentLocation(GameTime time)
- - public virtual void OnBoatEventEnd()
- - public override bool RunLocationSpecificEventCommand(Event current_event, string command_string, bool first_run, params string[] args)
- - public virtual void OnReachedBoatDeck(Character character, GameLocation location)
- - public override void MakeMapModifications(bool force = false)
- - public virtual void ResetBoat()
- - public Vector2 GetBoatPosition()
- - public override void draw(SpriteBatch b)

## Private Members
- - private Texture2D boatTexture;
- - private Vector2 boatPosition;
- - private void checkForBoatComplete()

## Protected Members
- - protected int _gateFrame;
- - protected int _gateDirection;
- - protected float _gateFrameTimer;
- - protected int _boatOffset;
- - protected int _boatDirection;
- - protected Farmer _farmerActor;
- - protected Event _boatEvent;
- - protected bool _playerPathing;
- - protected int nonBlockingPause;
- - protected float _nextBubble;
- - protected float _nextSlosh;
- - protected float _nextSmoke;
- - protected float _plankShake;
- - protected int forceWarpTimer;
- - protected bool _boatAnimating;
- - protected override void resetLocalState()

## Internal Members
- *(None)*

## Other Members
- *(None)*
