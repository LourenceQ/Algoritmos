/*
1790. Check if One String Swap Can Make Strings Equal
Easy
You are given two strings s1 and s2 of equal length. A string swap is an operation
where you choose two indices in a string (not necessarily different) and swap the 
characters at these indices.

Return true if it is possible to make both strings equal by performing at most one 
string swap on exactly one of the strings. Otherwise, return false.

Example 1:

Input: s1 = "bank", s2 = "kanb"
Output: true
Explanation: For example, swap the first character with the last character of s2 
to make "bank".
Example 2:

Input: s1 = "attack", s2 = "defend"
Output: false
Explanation: It is impossible to make them equal with one string swap.
Example 3:

Input: s1 = "kelb", s2 = "kelb"
Output: true
Explanation: The two strings are already equal, so no string swap operation is required.
 
Constraints:

1 <= s1.length, s2.length <= 100
s1.length == s2.length
s1 and s2 consist of only lowercase English letters.
*/

using System;

namespace CheckIfOneStringSwapCanMakeStringsEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "kelb";
            string s2 = "kelb";
            var res = AreAlmostEqual(s1, s2);
            Console.WriteLine(res);
        }

        private static bool AreAlmostEqual(string s1, string s2)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;

            if (s1 == null && s2 == null) { return true; }

            else if (len1 != len2) { return false; }

            int ct = 0;
            int[] c1 = new int[26], c2 = new int[26];

            for (int i = 0; i < len1; i++)
            {
                c1[s1[i] - 'a'] += 1;
                c2[s2[i] - 'a'] += 1;

                if(s1[i] != s2[i])
                {
                    if(ct == 2) {return false;}
                    else {ct++;}
                }
            }

            for (int i = 0; i < 26; i++)
            {
                if(c1[i] != c2[i]) {return false;}
            }

            return true;
        }
    }
}
