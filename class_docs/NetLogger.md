# NetLogger

**Summary:** Handles networking or multiplayer state.

## Public Members
- - public bool IsLogging
- - public double LogDuration
- - public void LogWrite(string path, long length)
- - public void Clear()
- - public string Dump()

## Private Members
- - private Dictionary<string, NetLogRecord> loggedWrites = new Dictionary<string, NetLogRecord>();
- - private DateTime timeLastStarted;
- - private double priorMillis;
- - private bool isLogging;

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
