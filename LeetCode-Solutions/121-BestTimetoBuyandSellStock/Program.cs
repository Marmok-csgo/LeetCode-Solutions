using System;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length == 0)
        {
            return 0;
        }

        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (int price in prices)
        {
            if (price < minPrice)
            {
                minPrice = price;
            }
            else
            {
                maxProfit = Math.Max(maxProfit, price - minPrice);
            }
        }

        return maxProfit;
    }
}
