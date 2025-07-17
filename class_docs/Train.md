# Train

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int minCars = 8;
- - public const int maxCars = 24;
- - public const double chanceForLongTrain = 0.1;
- - public const int randomTrain = 0;
- - public const int jojaTrain = 1;
- - public const int coalTrain = 2;
- - public const int passengerTrain = 3;
- - public const int uniformColorPlainTrain = 4;
- - public const int prisonTrain = 5;
- - public const int christmasTrain = 6;
- - public readonly NetObjectList<TrainCar> cars = new NetObjectList<TrainCar>();
- - public readonly NetInt type = new NetInt();
- - public readonly NetPosition position = new NetPosition();
- - public float speed;
- - public float wheelRotation;
- - public float smokeTimer;
- - public NetFields NetFields { get; } = new NetFields("Train");
- - public Train()
- - public Rectangle getBoundingBox()
- - public bool Update(GameTime time, GameLocation location)
- - public void draw(SpriteBatch b, GameLocation location)

## Private Members
- - private TemporaryAnimatedSprite whistleSteam;
- - private void initNetFields()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
