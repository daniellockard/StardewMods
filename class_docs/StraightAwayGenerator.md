# StraightAwayGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public int straightAwayLength = 10;
- - public List<int> staggerPattern;
- - public int minLength = 3;
- - public int maxLength = 5;
- - public float staggerChance = 0.25f;
- - public int minimuimDistanceBetweenStaggers = 1;
- - public int currentStaggerDistance;
- - public bool generateCheckpoint = true;
- - public StraightAwayGenerator SetMinimumDistanceBetweenStaggers(int min)
- - public StraightAwayGenerator SetLength(int min, int max)
- - public StraightAwayGenerator SetCheckpoint(bool checkpoint)
- - public StraightAwayGenerator SetStaggerChance(float chance)
- - public StraightAwayGenerator SetStaggerValues(params int[] args)
- - public StraightAwayGenerator SetStaggerValueRange(int min, int max)
- - public StraightAwayGenerator(MineCart game)
- - public override void Initialize()

## Private Members
- *(None)*

## Protected Members
- - protected bool _generatedCheckpoint = true;
- - protected override void _GenerateTrack()

## Internal Members
- *(None)*

## Other Members
- *(None)*
