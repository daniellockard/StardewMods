# BuildingPaintColor

**Summary:** Represents a building on the farm (barn, coop, etc.).

## Public Members
- - public NetString ColorName = new NetString();
- - public NetBool Color1Default = new NetBool(value: true);
- - public NetInt Color1Hue = new NetInt();
- - public NetInt Color1Saturation = new NetInt();
- - public NetInt Color1Lightness = new NetInt();
- - public NetBool Color2Default = new NetBool(value: true);
- - public NetInt Color2Hue = new NetInt();
- - public NetInt Color2Saturation = new NetInt();
- - public NetInt Color2Lightness = new NetInt();
- - public NetBool Color3Default = new NetBool(value: true);
- - public NetInt Color3Hue = new NetInt();
- - public NetInt Color3Saturation = new NetInt();
- - public NetInt Color3Lightness = new NetInt();
- - public NetFields NetFields { get; } = new NetFields("BuildingPaintColor");
- - public BuildingPaintColor()
- - public virtual void CopyFrom(BuildingPaintColor other)
- - public virtual void OnDefaultFlagChanged(NetBool field, bool old_value, bool new_value)
- - public virtual void OnColorChanged(NetInt field, int old_value, int new_value)
- - public virtual void Poll(Action apply)
- - public bool IsDirty()
- - public bool RequiresRecolor()

## Private Members
- *(None)*

## Protected Members
- - protected bool _dirty;

## Internal Members
- *(None)*

## Other Members
- *(None)*
