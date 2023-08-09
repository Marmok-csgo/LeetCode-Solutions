using System;
using System.Collections.Generic;

public class Solution
{
    public string ReverseVowels(string s)
    {
        HashSet<char> vowels = new HashSet<char>("aeiouAEIOU");
        char[] arr = s.ToCharArray();
        int left = 0;
        int right = s.Length - 1;

        while (left <= right)
        {
            if (vowels.Contains(arr[left]) && vowels.Contains(arr[right]))
            {
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            else if (vowels.Contains(arr[left]))
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return new string(arr);
    }
}
