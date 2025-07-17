# GalaxyAuthListener

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public GalaxyAuthListener(Action success, Action<FailureReason> failure, Action lost)
- - public override void OnAuthSuccess()
- - public override void OnAuthFailure(FailureReason reason)
- - public override void OnAuthLost()
- - public override void Dispose()

## Private Members
- - private readonly Action OnSuccess;
- - private readonly Action<FailureReason> OnFailure;
- - private readonly Action OnLost;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
