# TankFish

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public enum FishType
- - public const int field_spriteIndex = 0;
- - public const int field_type = 1;
- - public const int field_idleAnimations = 2;
- - public const int field_dartStartFrames = 3;
- - public const int field_dartHoldFrames = 4;
- - public const int field_dartEndFrames = 5;
- - public const int field_texture = 6;
- - public const int field_hatOffset = 7;
- - public Vector2 position;
- - public float zPosition;
- - public bool facingLeft;
- - public Vector2 velocity = Vector2.Zero;
- - public float nextSwim;
- - public string fishItemId = "";
- - public int fishIndex;
- - public int currentFrame;
- - public Point? hatPosition;
- - public int frogVariant;
- - public int numberOfDarts;
- - public FishType fishType;
- - public float minimumVelocity;
- - public float fishScale = 1f;
- - public List<int> currentAnimation;
- - public List<int> idleAnimation;
- - public List<int> dartStartAnimation;
- - public List<int> dartHoldAnimation;
- - public List<int> dartEndAnimation;
- - public int currentAnimationFrame;
- - public float currentFrameTime;
- - public float nextBubble;
- - public bool isErrorFish;
- - public TankFish(FishTankFurniture tank, Item item)
- - public void SetAnimation(List<int> frames)
- - public virtual void Draw(SpriteBatch b, float alpha, float draw_layer)
- - public bool CanWearHat()
- - public Vector2 GetWorldPosition()
- - public void ConstrainToTank()
- - public virtual float GetScale()
- - public Rectangle GetBounds()
- - public virtual void Update(GameTime time)

## Private Members
- *(None)*

## Protected Members
- - protected FishTankFurniture _tank;
- - protected Texture2D _texture;

## Internal Members
- *(None)*

## Other Members
- *(None)*
