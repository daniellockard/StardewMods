# HookableServer

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public Action<IncomingMessage, Action<OutgoingMessage>, Action> OnProcessingMessage { get; set; }
- - public HookableServer(IGameServer gameServer)
- - public interface IBandwidthMonitor
- - public interface IHookableClient
- - public interface IHookableServer

## Private Members
- - private void OnServerProcessingMessage(IncomingMessage message, Action<OutgoingMessage> sendMessage, Action resume)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
