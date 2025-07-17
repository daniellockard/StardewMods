# IncomingMessage

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public byte MessageType => messageType;
- - public long FarmerID => farmerID;
- - public Farmer SourceFarmer => Game1.GetPlayer(farmerID) ?? Game1.MasterPlayer;
- - public byte[] Data => data;
- - public BinaryReader Reader => reader;
- - public void Read(BinaryReader reader)
- - public void Dispose()

## Private Members
- - private byte messageType;
- - private long farmerID;
- - private byte[] data;
- - private MemoryStream stream;
- - private BinaryReader reader;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
