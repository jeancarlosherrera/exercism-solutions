namespace AnnalynsAttack
{
    class LogLine
    {
        public enum LogLevel
        {
            Trace = 1,
            Debug = 2,
            Info = 4,
            Warning = 5,
            Error = 6,
            Fatal = 42,
            Unknown = 0
        }

        public static LogLevel ParseLogLevel(string logLine) => logLine.SubstringBetween("[", "]") switch
        {
            "TRC" => LogLevel.Trace,
            "DBG" => LogLevel.Debug,
            "INF" => LogLevel.Info,
            "WRN" => LogLevel.Warning,
            "ERR" => LogLevel.Error,
            "FTL" => LogLevel.Fatal,
            _ => LogLevel.Unknown
        };

        public static string OutputForShortLog(LogLevel logLevel, string logLine)
        {
            return $"{(int)logLevel}:{logLine}";
        }
    }
}
