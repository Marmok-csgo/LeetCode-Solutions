using System;

public class Solution
{
    public int DaysBetweenDates(string date1, string date2)
    {
        DateTime D1 = new DateTime(
            int.Parse(date1.Substring(0, 4)),
            int.Parse(date1.Substring(5, 2)),
            int.Parse(date1.Substring(8))
        );

        DateTime D2 = new DateTime(
            int.Parse(date2.Substring(0, 4)),
            int.Parse(date2.Substring(5, 2)),
            int.Parse(date2.Substring(8))
        );

        TimeSpan Res = D1 - D2;
        return Math.Abs(Res.Days);
    }
}