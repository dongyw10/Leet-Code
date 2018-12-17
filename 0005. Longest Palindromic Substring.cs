    public class Solution
    {

       public string expandAroundCenter(string s, int c1, int c2)
        {
            int l = c1, r = c2;
            int n = s.Length;
            while (l >= 0 && r <= n - 1 && s[l] == s[r])
            {
                l--;
                r++;
            }
            return s.Substring(l + 1, r - l - 1);
        }

       public  string LongestPalindrome(string s)
        {
            int n = s.Length;
            if (n == 0) return "";
            string longest = s.Substring(0, 1);  // a single char itself is a palindrome
            for (int i = 0; i < n - 1; i++)
            {
                string p1 = expandAroundCenter(s, i, i);
                if (p1.Length > longest.Length)
                    longest = p1;

                string p2 = expandAroundCenter(s, i, i + 1);
                if (p2.Length > longest.Length)
                    longest = p2;
            }
            return longest;
        }

    }
