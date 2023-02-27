using System;
using UnityEngine;

public class CustomLogger : Logger {

  public CustomLogger(string prefix) : this(prefix, new DeafultLogHandler()) { }

  public CustomLogger(string prefix, ILogHandler logHandler) : base(logHandler) {
    _prefix = prefix;
  }

  private object prefix(object message) {
    return $"{_prefix}: {message}";
  }

  private readonly string _prefix;

  new public void Log(LogType logType, object message) {
    base.Log(logType, message);
  }

  new public void Log(LogType logType, object message, UnityEngine.Object context) {
    base.Log(logType, prefix(message), context);
  }

  new public void Log(LogType logType, string tag, object message) {
    base.Log(logType, tag, prefix(message));
  }

  new public void Log(LogType logType, string tag, object message, UnityEngine.Object context) {
    base.Log(logType, tag, prefix(message), context);
  }

  new public void Log(object message) {
    base.Log(prefix(message));
  }

  new public void Log(string tag, object message) {
    base.Log(tag, prefix(message));
  }

  new public void Log(string tag, object message, UnityEngine.Object context) {
    base.Log(tag, prefix(message), context);
  }

  public void LogWarning(object message) {
    base.Log(LogType.Warning, prefix(message));
  }

  new public void LogWarning(string tag, object message) {
    base.LogWarning(tag, prefix(message));
  }

  new public void LogWarning(string tag, object message, UnityEngine.Object context) {
    base.LogWarning(tag, prefix(message), context);
  }
  public void LogError(object message) {
    base.Log(LogType.Error, prefix(message));
  }
  new public void LogError(string tag, object message) {
    base.LogError(tag, prefix(message));
  }

  new public void LogError(string tag, object message, UnityEngine.Object context) {
    base.LogError(tag, prefix(message), context);
  }

  new public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args) {
    base.LogFormat(logType, context, format, args);
  }

  new public void LogException(Exception exception) {
    base.LogException(exception);
  }

  new public void LogException(Exception exception, UnityEngine.Object context) {
    logHandler.LogException(exception, context);
  }

  // ===== end boilerplate wrapper code ====

  public class DeafultLogHandler : ILogHandler {
    public void LogFormat(LogType logType, UnityEngine.Object context, string format, params object[] args) {
      Debug.unityLogger.logHandler.LogFormat(logType, context, format, args);
    }

    public void LogException(Exception exception, UnityEngine.Object context) {
      Debug.unityLogger.LogException(exception, context);
    }
  }
}