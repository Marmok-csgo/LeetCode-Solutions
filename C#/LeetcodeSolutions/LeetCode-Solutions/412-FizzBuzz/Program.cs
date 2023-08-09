using System;
using System.Collections.Generic;

public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> resultList = new List<string>();

        for (int i = 1; i <= n; i++)
        {
            string result = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                            (i % 3 == 0) ? "Fizz" :
                            (i % 5 == 0) ? "Buzz" : i.ToString();

            resultList.Add(result);
        }

        return resultList;
    }
}
