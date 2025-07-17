# Friendship

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public NetFields NetFields { get; } = new NetFields("Friendship");
- - public int Points
- - public int GiftsThisWeek
- - public int GiftsToday
- - public WorldDate LastGiftDate
- - public bool TalkedToToday
- - public bool ProposalRejected
- - public WorldDate WeddingDate
- - public WorldDate NextBirthingDate
- - public FriendshipStatus Status
- - public long Proposer
- - public bool RoommateMarriage
- - public int DaysMarried
- - public int CountdownToWedding
- - public int DaysUntilBirthing
- - public Friendship()
- - public Friendship(int startingPoints)
- - public void Clear()
- - public bool IsDating()
- - public bool IsEngaged()
- - public bool IsMarried()
- - public bool IsDivorced()
- - public bool IsRoommate()

## Private Members
- - private readonly NetInt points = new NetInt();
- - private readonly NetInt giftsThisWeek = new NetInt();
- - private readonly NetInt giftsToday = new NetInt();
- - private readonly NetRef<WorldDate> lastGiftDate = new NetRef<WorldDate>();
- - private readonly NetBool talkedToToday = new NetBool();
- - private readonly NetBool proposalRejected = new NetBool();
- - private readonly NetRef<WorldDate> weddingDate = new NetRef<WorldDate>();
- - private readonly NetRef<WorldDate> nextBirthingDate = new NetRef<WorldDate>();
- - private readonly NetEnum<FriendshipStatus> status = new NetEnum<FriendshipStatus>(FriendshipStatus.Friendly);
- - private readonly NetLong proposer = new NetLong();
- - private readonly NetBool roommateMarriage = new NetBool(value: false);

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
