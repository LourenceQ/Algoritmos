/*
316. Remove Duplicate Letters
Medium

Given a string s, remove duplicate letters so that every letter appears once and only once. 
You must make sure your result is the smallest in lexicographical order among all possible 
results.

Example 1:

Input: s = "bcabc"
Output: "abc"
Example 2:

Input: s = "cbacdcbc"
Output: "acdb"
 

Constraints:

1 <= s.length <= 104
s consists of lowercase English letters.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveDuplicateLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cbacdcbc";
            var res = RemoveDuplicateLetters(s);
            System.Console.WriteLine(res);
        }

        public static string RemoveDuplicateLetters(string s)
        {
            if (string.IsNullOrEmpty(s)) { return s; }

            var lastIndex = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                lastIndex[s[i] - 'a']++;
            }

            StringBuilder sb = new StringBuilder();
            HashSet<char> hs = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                lastIndex[s[i] - 'a']--;

                if (hs.Contains(s[i])) { continue; }

                while (sb.Length > 0 && sb[sb.Length - 1] > s[i] && lastIndex[sb[sb.Length - 1] - 'a'] > 0)
                {
                    hs.Remove(sb[sb.Length - 1]);
                    sb.Length--;
                }
                hs.Add(s[i]);
                sb.Append(s[i]);
            }
            return sb.ToString();

        }
    }
}
