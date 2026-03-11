enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        var levelStr = logLine.Split("]: ")[0].Replace("[", "");
        LogLevel level;
        switch (levelStr)
        {
            case "TRC":
                level = LogLevel.Trace;
                break;
            case "DBG":
                level = LogLevel.Debug;
                break;
            case "INF":
                level = LogLevel.Info;
                break;
            case "WRN":
                level = LogLevel.Warning;
                break;
            case "ERR":
                level = LogLevel.Error;
                break;
            case "FTL":
                level = LogLevel.Fatal;
                break;
            default:
                level = LogLevel.Unknown;
                break;
        }

        return level;
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        // string level = logLevel switch
        // {
        //         LogLevel.Trace => "TRC",
        //         LogLevel.Debug => "DBG",
        //         LogLevel.Info => "INF",
        //         LogLevel.Warning => "WRN",
        //         LogLevel.Error => "ERR",
        //         LogLevel.Fatal => "FTL"
        // };
        return $"{(int)logLevel}:{message}";
    }
}
