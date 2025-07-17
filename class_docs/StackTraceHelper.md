# StackTraceHelper

**Summary:** Utility or helper class.

## Public Members
- - public static string StackTrace => Environment.StackTrace;
- - public int FrameCount => (_StackTrace as StackTrace)?.FrameCount ?? 0;
- - public static string FromException(Exception ex)
- - public StackTraceHelper()
- - public StackFrame GetFrame(int index)
- - public StackFrame[] GetFrames()
- - public new string ToString()

## Private Members
- - private object _StackTrace;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
