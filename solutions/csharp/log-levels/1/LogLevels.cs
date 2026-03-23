static class LogLine
{
    public static string Message(string logLine)
    {
        logLine = logLine.Trim();
        int messageStart = logLine.IndexOf(" ") + 1;
        return logLine.Substring(messageStart).Trim();
    }

    public static string LogLevel(string logLine)
    {
        logLine = logLine.Trim();
        return logLine.Substring(1, logLine.IndexOf("]") - 1).Trim().ToLower();
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + " (" + LogLevel(logLine).ToLower() + ")";
    }
}
