public class Solution {
    public string ReverseOnlyLetters(string s) {
        char[] charArray = s.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;
        
        while (left < right) {
            if (!Char.IsLetter(charArray[left])) {
                left++;
            }
            else if (!Char.IsLetter(charArray[right])) {
                right--;
            }
            else {
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;
                left++;
                right--;
            }
        }
        
        return new string(charArray);
    }
}