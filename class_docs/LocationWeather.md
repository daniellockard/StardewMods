# LocationWeather

**Summary:** Represents a place or area in the game world.

## Public Members
- - public readonly NetString weatherForTomorrow = new NetString();
- - public readonly NetString weather = new NetString();
- - public readonly NetBool isRaining = new NetBool();
- - public readonly NetBool isSnowing = new NetBool();
- - public readonly NetBool isLightning = new NetBool();
- - public readonly NetBool isDebrisWeather = new NetBool();
- - public readonly NetBool isGreenRain = new NetBool();
- - public readonly NetInt monthlyNonRainyDayCount = new NetInt();
- - public NetFields NetFields { get; } = new NetFields("LocationWeather");
- - public string WeatherForTomorrow
- - public string Weather
- - public bool IsRaining
- - public bool IsSnowing
- - public bool IsLightning
- - public bool IsDebrisWeather
- - public bool IsGreenRain
- - public LocationWeather()
- - public void InitializeDayWeather()
- - public void UpdateDailyWeather(string locationContextId, LocationContextData data, Random random)
- - public void CopyFrom(LocationWeather other)

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
