public class Solution {
    public int DayOfYear(string date) {
        string[] dateParts = date.Split('-');
        int y = int.Parse(dateParts[0]);
        int m = int.Parse(dateParts[1]);
        int d = int.Parse(dateParts[2]);
        
        if ((y % 400 == 0 || (y % 100 != 0 && y % 4 == 0)) && m > 2) {
            d++;
        }
        
        int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        
        for (int i = 1; i < m; i++) {
            d += months[i - 1];
        }
        
        return d;
    }
}