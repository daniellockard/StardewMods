# DebugMetricsComponent

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int XOffset = 10;
- - public int YOffset = 10;
- - public SpriteFont Font
- - public DebugMetricsComponent(Game game)
- - public override void Update(GameTime gameTime)
- - public override void Draw(GameTime gameTime)

## Private Members
- - private readonly Game _game;
- - private SpriteFont _font;
- - private SpriteBatch _spriteBatch;
- - private int _drawX;
- - private int _drawY;
- - private double _fps;
- - private double _mspf;
- - private int _lastCollection;
- - private float _lastBaseMB;
- - private bool _runningSlowly;
- - private StringBuilder _stringBuilder = new StringBuilder(512);
- - private Texture2D _opaqueWhite;
- - private IBandwidthMonitor bandwidthMonitor;
- - private BarGraph bandwidthUpGraph;
- - private BarGraph bandwidthDownGraph;
- - private void DrawLine(Color color, StringBuilder sb, int x)

## Protected Members
- - protected override void LoadContent()

## Internal Members
- *(None)*

## Other Members
- *(None)*
