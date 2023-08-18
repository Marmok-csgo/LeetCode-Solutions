using System;

public class Solution
{
    public string DayOfTheWeek(int d, int m, int y)
    {
        DateTime date = new DateTime(y, m, d);
        return date.ToString("dddd");
    }
}