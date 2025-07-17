# ReadyCheckDialog

**Summary:** Handles in-game dialogue or conversations.

## Public Members
- - public string checkName;
- - public ReadyCheckDialog(string checkName, bool allowCancel, behavior onConfirm = null, behavior onCancel = null)
- - public bool isCancelable()
- - public override bool readyToClose()
- - public override void closeDialog(Farmer who)
- - public override void receiveKeyPress(Keys key)
- - public override void update(GameTime time)

## Private Members
- - private bool allowCancel;
- - private void updateMessage()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
