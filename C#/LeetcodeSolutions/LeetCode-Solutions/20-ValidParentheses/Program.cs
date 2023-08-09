public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char ch in s)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                if ((ch == ')' && stack.Peek() == '(') ||
                    (ch == '}' && stack.Peek() == '{') ||
                    (ch == ']' && stack.Peek() == '['))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}