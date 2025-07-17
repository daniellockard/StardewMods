# BaseSetFlagRequest

**Summary:** Represents a quest or mission.

## Public Members
- - public string FlagId { get; private set; }
- - public bool FlagState { get; private set; }
- - public override void Read(BinaryReader reader)
- - public override void Write(BinaryWriter writer)
- - public enum MailType : byte

## Private Members
- *(None)*

## Protected Members
- - protected BaseSetFlagRequest()
- - protected BaseSetFlagRequest(PlayerActionTarget target, string flagId, bool flagState, long? onlyPlayerId)

## Internal Members
- *(None)*

## Other Members
- *(None)*
