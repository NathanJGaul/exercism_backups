public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        var divisibleByOneHundred = year % 100 == 0;
        var divisibleByFour = year % 4 == 0;
        var divisibleByFourHundred = year % 400 == 0;

        return (divisibleByOneHundred && divisibleByFourHundred) || 
            (!divisibleByOneHundred && divisibleByFour);
    }
}