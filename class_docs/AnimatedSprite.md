# AnimatedSprite

**Summary:** Represents a 2D image or animation.

## Public Members
- - public delegate void endOfAnimationBehavior(Farmer who);
- - public Texture2D spriteTexture;
- - public string loadedTexture;
- - public string overrideTextureName;
- - public readonly NetString textureName = new NetString();
- - public float timer;
- - public float interval = 175f;
- - public int framesPerAnimation = 4;
- - public int currentFrame;
- - public readonly NetInt spriteWidth = new NetInt(16);
- - public readonly NetInt spriteHeight = new NetInt(24);
- - public int tempSpriteHeight = -1;
- - public Rectangle sourceRect;
- - public bool loop = true;
- - public bool ignoreStopAnimation;
- - public bool textureUsesFlippedRightForLeft;
- - public endOfAnimationBehavior endOfAnimationFunction;
- - public readonly List<FarmerSprite.AnimationFrame> currentAnimation = new List<FarmerSprite.AnimationFrame>(12);
- - public int oldFrame;
- - public int currentAnimationIndex;
- - public bool ignoreSourceRectUpdates;
- - public NetFields NetFields { get; } = new NetFields("AnimatedSprite");
- - public Texture2D Texture
- - public int SpriteWidth
- - public int SpriteHeight
- - public virtual int CurrentFrame
- - public List<FarmerSprite.AnimationFrame> CurrentAnimation
- - public Rectangle SourceRect
- - public virtual Character Owner { get; protected set; }
- - public AnimatedSprite()
- - public AnimatedSprite(ContentManager contentManager, string textureName, int currentFrame, int spriteWidth, int spriteHeight)
- - public AnimatedSprite(ContentManager contentManager, string textureName)
- - public AnimatedSprite(string textureName, int currentFrame, int spriteWidth, int spriteHeight)
- - public AnimatedSprite(string textureName)
- - public virtual void SetOwner(Character owner)
- - public virtual void LoadTexture(string textureName, bool syncTextureName = true)
- - public int getHeight()
- - public int getWidth()
- - public virtual void StopAnimation()
- - public virtual void standAndFaceDirection(int direction)
- - public virtual void faceDirectionStandard(int direction)
- - public virtual void faceDirection(int direction)
- - public virtual void AnimateRight(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
- - public virtual void AnimateUp(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
- - public virtual void AnimateDown(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
- - public virtual void AnimateLeft(GameTime gameTime, int intervalOffset = 0, string soundForFootstep = "")
- - public virtual bool Animate(GameTime gameTime, int startFrame, int numberOfFrames, float interval)
- - public virtual void ClearAnimation()
- - public virtual void AddFrame(FarmerSprite.AnimationFrame frame)
- - public virtual void setCurrentAnimation(List<FarmerSprite.AnimationFrame> animation)
- - public virtual bool animateOnce(GameTime time)
- - public virtual void UpdateSourceRect()
- - public virtual void draw(SpriteBatch b, Vector2 screenPosition, float layerDepth)
- - public virtual void draw(SpriteBatch b, Vector2 screenPosition, float layerDepth, int xOffset, int yOffset, Color c, bool flip = false, float scale = 1f, float rotation = 0f, bool characterSourceRectOffset = false)
- - public virtual void drawShadow(SpriteBatch b, Vector2 screenPosition, float scale = 4f, float alpha = 1f)
- - public virtual void drawShadow(SpriteBatch b, Vector2 screenPosition, float scale = 4f)
- - public virtual AnimatedSprite Clone()
- - public static Rectangle GetSourceRect(int textureWidth, int spriteWidth, int spriteHeight, int frame)

## Private Members
- - private void loadTexture()

## Protected Members
- - protected ContentManager contentManager;
- - protected int textureWidth
- - protected int textureHeight
- - protected virtual void initNetFields()

## Internal Members
- *(None)*

## Other Members
- *(None)*
