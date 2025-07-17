# MushroomBalanceTrackGenerator

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public MushroomBalanceTrackGenerator SetTrackType(Track.TrackType track_type)
- - public MushroomBalanceTrackGenerator SetStaggerValues(params int[] args)
- - public MushroomBalanceTrackGenerator SetReleaseJumpChance(float chance)
- - public MushroomBalanceTrackGenerator SetHopSize(int min, int max)
- - public MushroomBalanceTrackGenerator(MineCart game)

## Private Members
- *(None)*

## Protected Members
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
