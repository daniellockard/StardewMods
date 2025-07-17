# MushroomSpring

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Rectangle[] frames = (Rectangle[])(object)new Rectangle[3]
- - public int currentFrame;
- - public float frameDuration = 0.05f;
- - public float frameTimer;
- - public override Rectangle GetLocalBounds()
- - public override void InitializeObstacle(Track track)
- - public override void _Draw(SpriteBatch b)
- - public override bool CanSpawnHere(Track track)
- - public override bool OnBounce(MineCartCharacter player)
- - public override bool OnBump(PlayerMineCartCharacter player)
- - public void BouncePlayer(MineCartCharacter player)
- - public void ShootDebris(int x, int y)
- - public override void OnPlayerReset()

## Private Members
- *(None)*

## Protected Members
- - protected HashSet<MineCartCharacter> _bouncedPlayers;
- - protected override void _Update(float time)

## Internal Members
- *(None)*

## Other Members
- *(None)*
