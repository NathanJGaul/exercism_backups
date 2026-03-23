using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimitor)
    {
        var index = str.IndexOf(delimitor);
        if (index < 0) return string.Empty;
        return str.Substring(index + delimitor.Length);
    }

    public static string SubstringBetween(this string str, string startStr, string endStr)
    {
        var startIndex = str.IndexOf(startStr) + startStr.Length;
        var endIndex = str.IndexOf(endStr);
        var substringLength = (endIndex - startIndex);
        if (startIndex < 0 || endIndex < 0) return string.Empty;
        return str.Substring(startIndex, substringLength);
    }
    
    public static string Message(this string str) => str.SubstringAfter(": ");
    
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}