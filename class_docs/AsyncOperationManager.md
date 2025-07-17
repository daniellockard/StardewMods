# AsyncOperationManager

**Summary:** Handles or manages a specific system or feature.

## Public Members
- - public static AsyncOperationManager Use => _instance;
- - public static void Init()
- - public void AddPending(Task task, Action<GenericResult> doneAction)
- - public void AddPending(Action workAction, Action<GenericResult> doneAction)
- - public void AddPending(IAsyncOperation op)
- - public void Update()

## Private Members
- - private static AsyncOperationManager _instance;
- - private List<IAsyncOperation> _pendingOps;
- - private List<IAsyncOperation> _tempOps;
- - private List<IAsyncOperation> _doneOps;
- - private AsyncOperationManager()

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
