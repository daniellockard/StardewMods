# SetMailRequest

**Summary:** Represents a quest or mission.

## Public Members
- - public MailType MailType { get; private set; } = MailType.Tomorrow;
- - public SetMailRequest()
- - public SetMailRequest(PlayerActionTarget target, string mailId, MailType mailType, bool state, long? onlyPlayerId = null)
- - public override void PerformAction(Farmer farmer)
- - public override void Read(BinaryReader reader)
- - public override void Write(BinaryWriter writer)

## Private Members
- - private void ToggleMailbox(Farmer farmer, string mailId, bool add)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
