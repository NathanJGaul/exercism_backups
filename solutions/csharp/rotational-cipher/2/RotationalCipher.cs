using System.Linq;
using System.Text.RegularExpressions;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        return string.Join("", text.ToCharArray()
            .Select(ch => 
                {
                    if (Char.IsLetter(ch))
                    {
                        int offset = Char.IsUpper(ch) ? 65 : 97;
                        int normal = ch - offset;
                        return (char) ((normal + shiftKey) % 26 + offset);
                    }

                    return ch;
                }
            )
            .ToArray());
    }
}