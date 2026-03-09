using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder(identifier, 100);
        sb.Replace(' ', '_');
        
        var str = sb.ToString();
        str = string.Join("", str.ToCharArray().Select(c => Char.IsControl(c) ? "CTRL" : c.ToString()));

        var camelChars = new List<char>();
        var prevDash = false;
        foreach (char ch in str.ToCharArray())
        {
            if (ch == '-')
            {
                prevDash = true;
            }
            else
            {
                if (prevDash)
                {
                    camelChars.Add(Char.ToUpper(ch));
                }
                else
                {
                    camelChars.Add(ch);
                }
                prevDash = false;
            }
        }
        str = new string(camelChars.ToArray());

        str = Regex.Replace(str, @"[^\w]", "");
        str = Regex.Replace(str, @"[\d]", "");
        str = Regex.Replace(str, @"[α-ω]", "");

        return str;
    }
}
