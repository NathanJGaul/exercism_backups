using System.Linq;
using System.Text.RegularExpressions;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        return string.Join("", text.ToCharArray()
            .Select(ch => Regex.IsMatch(ch.ToString(), @"[a-z]", RegexOptions.IgnoreCase) ?
                    (char)((((ch - (Char.IsUpper(ch) ? 65 : 97)) + shiftKey) % 26) + (Char.IsUpper(ch) ? 65 : 97)) : ch)
            .ToArray());
    }
}