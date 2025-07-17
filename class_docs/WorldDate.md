# WorldDate

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int MonthsPerYear = 4;
- - public const int DaysPerMonth = 28;
- - public const int DaysPerYear = 112;
- - public int Year
- - public int SeasonIndex => (int)season.Value;
- - public int DayOfMonth
- - public DayOfWeek DayOfWeek => GetDayOfWeekFor(DayOfMonth);
- - public Season Season
- - public string SeasonKey
- - public int TotalDays
- - public int TotalWeeks => TotalDays / 7;
- - public int TotalSundayWeeks => (TotalDays + 1) / 7;
- - public NetFields NetFields { get; } = new NetFields("WorldDate");
- - public WorldDate()
- - public WorldDate(WorldDate other)
- - public WorldDate(int year, Season season, int dayOfMonth)
- - public WorldDate(int year, string seasonKey, int dayOfMonth)
- - public string Localize()
- - public override string ToString()
- - public override bool Equals(object obj)
- - public override int GetHashCode()
- - public static bool operator ==(WorldDate a, WorldDate b)
- - public static bool operator !=(WorldDate a, WorldDate b)
- - public static bool operator <(WorldDate a, WorldDate b)
- - public static bool operator >(WorldDate a, WorldDate b)
- - public static bool operator <=(WorldDate a, WorldDate b)
- - public static bool operator >=(WorldDate a, WorldDate b)
- - public static DayOfWeek GetDayOfWeekFor(int dayOfMonth)
- - public static WorldDate Now()
- - public static WorldDate ForDaysPlayed(int daysPlayed)
- - public static int GetDaysPlayed(int year, Season season, int dayOfMonth)
- - public static bool TryGetDayOfWeekFor(string day, out DayOfWeek dayOfWeek)

## Private Members
- - private readonly NetInt year = new NetInt(1);
- - private readonly NetEnum<Season> season = new NetEnum<Season>((Season)0);
- - private readonly NetInt dayOfMonth = new NetInt(1);

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
