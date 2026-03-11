using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        StringBuilder sb = new();

        // ID
        if (id != null) 
            sb.Append($"[{id}] - ");

        // Name
        sb.Append(name);

        // Department
        if (department != null) 
            sb.Append($" - {department.ToUpper()}");
        
        // Owners
        if (name == "Julie Sokato" || name == "Amare Osei")
            sb.Append(" - OWNER");
        
        return sb.ToString();
    }
}
