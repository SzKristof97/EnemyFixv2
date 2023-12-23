using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemyFix.Utilities
{
    public static class Logger
    {
        private static ManualLogSource _mls;

        private static void Log(LogLevel level, object msg)
        {
            if (string.IsNullOrEmpty(msg.ToString())) return;
            if (_mls == null) _mls = BepInEx.Logging.Logger.CreateLogSource(PluginInfos.NAME);

            _mls.Log(level, " " + msg.ToString());
        }

        public static void LogInfo(object msg)
        {
            Log(LogLevel.Info, msg);
        }
        public static void LogWarning(object msg)
        {
            Log(LogLevel.Warning, msg);
        }
        public static void LogError(object msg)
        {
            Log(LogLevel.Error, msg);
        }
        public static void LogDebug(object msg)
        {
            Log(LogLevel.Debug, msg);
        }
    }
}
