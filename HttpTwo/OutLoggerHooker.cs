using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpTwo
{
    public class OutLoggerHooker
    {
        public delegate void LogHook(string s);

        public static LogHook LogHooker = null;
        public static LogHook LogErrorHooker = null;
        public static LogHook LogWarningHooker = null;
        public static LogHook DebugLogHooker = null;

        public static void DebugLog(string s)
        {
            DebugLogHooker?.Invoke(s);
        }

        public static void Log(string s)
        {
            LogHooker?.Invoke(s);
        }

        public static void LogWarning(string s)
        {
            LogWarningHooker?.Invoke(s);
        }

        public static void LogError(string s)
        {
            LogErrorHooker?.Invoke(s);
        }
    }
}
