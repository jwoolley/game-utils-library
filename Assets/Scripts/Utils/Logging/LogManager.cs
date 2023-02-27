using System;
using System.Collections.Generic;

namespace GameUtils {
  public static class LogManager {

    public static CustomLogger getLogger(Type type) {
      if (!loggers.ContainsKey(type)) {
        loggers.Add(type, new CustomLogger($"[{type.Name}]"));
      }
      return loggers[type];
    }

    private static Dictionary<Type, CustomLogger> loggers = new Dictionary<Type, CustomLogger>(); 
  }
}