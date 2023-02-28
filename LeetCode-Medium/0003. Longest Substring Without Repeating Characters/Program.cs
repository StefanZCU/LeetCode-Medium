public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        int longestSubstring = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, i);
                longestSubstring = Math.Max(dict.Count, longestSubstring);
            }
            else
            {
                i = dict[c];
                dict.Clear();
            }
        }
        return longestSubstring;
    }
}