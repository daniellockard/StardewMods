# BunnyHopGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public BunnyHopGenerator SetTrackType(Track.TrackType track_type)
- - public BunnyHopGenerator SetStaggerValues(params int[] args)
- - public BunnyHopGenerator SetReleaseJumpChance(float chance)
- - public BunnyHopGenerator SetHopSize(int min, int max)
- - public BunnyHopGenerator SetNumberOfHops(int min, int max)
- - public BunnyHopGenerator(MineCart game)
- - public override void Initialize()

## Private Members
- *(None)*

## Protected Members
- - protected int numberOfHops;
- - protected int minHops = 1;
- - protected int maxHops = 5;
- - protected int minHopSize = 1;
- - protected int maxHopSize = 1;
- - protected float releaseJumpChance;
- - protected List<int> staggerPattern;
- - protected Track.TrackType trackType;
- - protected override void _GenerateTrack()

## Internal Members
- *(None)*

## Other Members
- *(None)*
