# SetSimpleFlagRequest

**Summary:** Represents a quest or mission.

## Public Members
- - public SimpleFlagType FlagType { get; private set; }
- - public SetSimpleFlagRequest()
- - public SetSimpleFlagRequest(SimpleFlagType flagType, PlayerActionTarget target, string flagId, bool flagState, long? onlyPlayerId)
- - public override void Read(BinaryReader reader)
- - public override void Write(BinaryWriter writer)
- - public override void PerformAction(Farmer farmer)
- - public enum SimpleFlagType : byte
- - public enum DedicatedServerMessageType : byte

## Private Members
- *(None)*

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
