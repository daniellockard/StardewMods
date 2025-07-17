# Warp

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public readonly NetBool flipFarmer = new NetBool();
- - public readonly NetBool npcOnly = new NetBool();
- - public NetFields NetFields { get; } = new NetFields("Warp");
- - public int X => x.Value;
- - public int Y => y.Value;
- - public int TargetX
- - public int TargetY
- - public string TargetName
- - public Warp()
- - public Warp(int x, int y, string targetName, int targetX, int targetY, bool flipFarmer, bool npcOnly = false)

## Private Members
- - private readonly NetInt x = new NetInt();
- - private readonly NetInt y = new NetInt();
- - private readonly NetInt targetX = new NetInt();
- - private readonly NetInt targetY = new NetInt();
- - private readonly NetString targetName = new NetString();

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
