# TV

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public const int customChannel = 1;
- - public const int weatherChannel = 2;
- - public const int fortuneTellerChannel = 3;
- - public const int tipsChannel = 4;
- - public const int cookingChannel = 5;
- - public const int fishingChannel = 6;
- - public TV()
- - public TV(string itemId, Vector2 tile)
- - public override bool checkForAction(Farmer who, bool justCheckingForActivity = false)
- - public virtual void selectChannel(Farmer who, string answer)
- - public virtual float getScreenSizeModifier()
- - public virtual Vector2 getScreenPosition()
- - public virtual void proceedToNextScene()
- - public virtual void turnOffTV()
- - public virtual void setFortuneOverlay(Farmer who)
- - public virtual string getFortuneForecast(Farmer who)
- - public override void draw(SpriteBatch spriteBatch, int x, int y, float alpha = 1f)

## Private Members
- - private int currentChannel;
- - private TemporaryAnimatedSprite screen;
- - private TemporaryAnimatedSprite screenOverlay;
- - private static Dictionary<int, string> weekToRecipeMap;
- - private string[] getFishingInfo()
- - private string getSanitizedFishingLocation(string rawLocationName)
- - private string[] getWeeklyRecipe(Dictionary<string, string> channelData, string id)
- - private string getIslandWeatherForecast()

## Protected Members
- - protected override Item GetOneNew()
- - protected virtual string getFortuneTellerOpening()
- - protected virtual string getWeatherChannelOpening()
- - protected virtual void setWeatherOverlay(bool island = false)
- - protected virtual void setWeatherOverlay(string weatherId)
- - protected virtual string getTodaysTip()
- - protected int getRerunWeek()
- - protected virtual string[] getWeeklyRecipe()
- - protected virtual string getWeatherForecast()
- - protected virtual string getWeatherForecast(string weatherId)

## Internal Members
- *(None)*

## Other Members
- *(None)*
