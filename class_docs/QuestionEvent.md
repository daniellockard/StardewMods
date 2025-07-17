# QuestionEvent

**Summary:** Represents a game event or cutscene.

## Public Members
- - public const int pregnancyQuestion = 1;
- - public const int barnBirth = 2;
- - public const int playerPregnancyQuestion = 3;
- - public FarmAnimal animal;
- - public bool forceProceed;
- - public QuestionEvent(int whichQuestion)
- - public override bool setUp()
- - public override bool tickUpdate(GameTime time)
- - public override void makeChangesToLocation()

## Private Members
- - private int whichQuestion;
- - private AnimalHouse animalHouse;
- - private void answerPregnancyQuestion(Farmer who, string answer)
- - private void answerPlayerPregnancyQuestion(Farmer who, string answer)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
