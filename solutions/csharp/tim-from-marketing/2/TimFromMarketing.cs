using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var idFormat = id==null ? "" : $"[{id}] - ";
        var depFormat = department?.ToUpper() ?? "OWNER";
        return $"{idFormat}{name} - {depFormat}";
    }
}
