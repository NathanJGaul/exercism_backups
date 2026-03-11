using System.Reflection;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
                break;
            case 2:
                return "left back";
                break;
            case 3:
            case 4:
                return "center back";
                break;
            case 5:
                return "right back";
                break;
            case 6:
            case 7:
            case 8:
                return "midfielder";
                break;
            case 9:
                return "left winger";
                break;
            case 10:
                return "striker";
                break;
            case 11:
                return "right wing";
                break;
            default:
                return "UNKNOWN";
                break;
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int number:
                return $"There are {number} supporters at the match.";
                break;
            case string text:
                return text;
                break;
            case Foul foul:
                return "The referee deemed a foul.";
                break;
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
                break;
            case Incident incident:
                return "An incident happened.";
                break;
            case Manager manager:
                var clubText = manager.Club==null ? "" : $" ({manager.Club})";
                return $"{manager.Name}{clubText}";
                break;
            default:
                return string.Empty;
                break;
        }
    }
}
