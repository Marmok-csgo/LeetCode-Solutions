public class Solution
{
    public string LicenseKeyFormatting(string s, int k)
        => string.Join('-', s.Where(c => c is not '-')
                .Select(char.ToUpper)
                .Reverse()
                .Chunk(k)
                .Select(x => new string(x.Reverse().ToArray()))
                .Reverse()
        );
}