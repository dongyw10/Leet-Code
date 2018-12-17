public class Solution {
    public int LengthOfLongestSubstring(string s) {
            IDictionary<char, int> map = new Dictionary<char, int>();
            int ans = 0;
            for (int i = 0, j = 0; j < s.Length; j++)
            {
                char currChar = s[j];
                if (map.ContainsKey(currChar))
                    i = Math.Max(map[currChar] + 1, i);
                ans = Math.Max(ans, j - i + 1);
                map[currChar] = j;
            }
            return ans;      
    }
}
