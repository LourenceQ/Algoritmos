/*
14. Longest Common Prefix
Easy

7323

2871

Add to List

Share
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lower-case English letters.
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        string[] a = { "dog", "racecar", "car" };
        var res = LongestCommonPrefix(a);
        Console.WriteLine(res);
    }

    public static string LongestCommonPrefix(string[] strs)
    {

        if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
            return "";

        string res = strs[0];
        int i = res.Length;
        foreach (string word in strs)
        {
            int j = 0;
            foreach (char c in word)
            {
                if (j >= i || res[j] != c)
                    break;
                j += 1;
            }
            i = Math.Min(i, j);
        }
        return res.Substring(0, i);

    }
}