# Proposal

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetFarmerRef sender = new NetFarmerRef();
- - public readonly NetFarmerRef receiver = new NetFarmerRef();
- - public readonly NetEnum<ProposalType> proposalType = new NetEnum<ProposalType>(ProposalType.Gift);
- - public readonly NetEnum<ProposalResponse> response = new NetEnum<ProposalResponse>(ProposalResponse.None);
- - public readonly NetString responseMessageKey = new NetString();
- - public readonly NetRef<Item> gift = new NetRef<Item>();
- - public readonly NetBool canceled = new NetBool();
- - public readonly NetBool cancelConfirmed = new NetBool();
- - public NetFields NetFields { get; } = new NetFields("Proposal");
- - public Proposal()
- - public struct FarmerPair
- - public long Farmer1;
- - public long Farmer2;
- - public static FarmerPair MakePair(long f1, long f2)
- - public bool Contains(long f)
- - public long GetOther(long f)
- - public bool Equals(FarmerPair other)
- - public override bool Equals(object obj)
- - public override int GetHashCode()

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
