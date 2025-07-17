# DefaultLogger

**Summary:** Class purpose not automatically determined. Review members for details.

## Public Members
- - public bool ShouldWriteToConsole { get; }
- - public bool ShouldWriteToLogFile { get; }
- - public DefaultLogger(bool shouldWriteToConsole, bool shouldWriteToLogFile)
- - public void Verbose(string message)
- - public void Debug(string message)
- - public void Info(string message)
- - public void Warn(string message)
- - public void Error(string error, Exception exception)
- - public interface IGameLogger

## Private Members
- - private readonly StringBuilder MessageBuilder = new StringBuilder();
- - private string _LogPath;
- - private bool StartedLogFile;
- - private string LogPath
- - private void WriteMessageToFile(string message)
- - private void LogImpl(string level, string message, Exception exception = null)
- - private string FormatLog(string level, string text, Exception exception = null)

## Protected Members
- *(None)*

## Internal Members
- *(None)*

## Other Members
- *(None)*
