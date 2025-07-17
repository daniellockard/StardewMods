# TrainCar

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int spotsForTopFeatures = 6;
- - public const double chanceForTopFeature = 0.2;
- - public const int engine = 3;
- - public const int passengerCar = 2;
- - public const int coalCar = 1;
- - public const int plainCar = 0;
- - public const int coal = 0;
- - public const int metal = 1;
- - public const int wood = 2;
- - public const int compartments = 3;
- - public const int grass = 4;
- - public const int hay = 5;
- - public const int bricks = 6;
- - public const int rocks = 7;
- - public const int packages = 8;
- - public const int presents = 9;
- - public readonly NetInt frontDecal = new NetInt();
- - public readonly NetInt carType = new NetInt();
- - public readonly NetInt resourceType = new NetInt();
- - public readonly NetInt loaded = new NetInt();
- - public readonly NetArray<int, NetInt> topFeatures = new NetArray<int, NetInt>(6);
- - public readonly NetBool alternateCar = new NetBool();
- - public readonly NetColor color = new NetColor();
- - public NetFields NetFields { get; } = new NetFields("TrainCar");
- - public TrainCar()
- - public TrainCar(Random random, int carType, int frontDecal, Color color, int resourceType = 0, int loaded = 0)
- - public void draw(SpriteBatch b, Vector2 globalPosition, float wheelRotation, GameLocation location)

## Private Members
- - private void initNetFields()
- - private void DrawFrontDecal(SpriteBatch b, Vector2 globalPosition)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
