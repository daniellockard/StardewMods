# HookableClient

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage { get; set; }
- - public Action<OutgoingMessage, Action<OutgoingMessage>, Action> OnSendingMessage { get; set; }
- - public HookableClient()

## Private Members
- - private void OnClientProcessingMessage(IncomingMessage message, Action<OutgoingMessage> sendMessage, Action resume)
- - private void OnClientSendingMessage(OutgoingMessage message, Action<OutgoingMessage> sendMessage, Action resume)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
