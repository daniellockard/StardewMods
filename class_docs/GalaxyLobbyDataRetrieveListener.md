# GalaxyLobbyDataRetrieveListener

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public GalaxyLobbyDataRetrieveListener(Action<GalaxyID> success, Action<GalaxyID, FailureReason> failure)
- - public override void OnLobbyDataRetrieveSuccess(GalaxyID lobbyID)
- - public override void OnLobbyDataRetrieveFailure(GalaxyID lobbyID, FailureReason failureReason)

## Private Members
- - private readonly Action<GalaxyID> OnSuccess;
- - private readonly Action<GalaxyID, FailureReason> OnFailure;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
