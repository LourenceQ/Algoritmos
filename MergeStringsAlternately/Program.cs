/*
1768. Merge Strings Alternately
Easy
You are given two strings word1 and word2. Merge the strings by adding 
letters in alternating order, starting with word1. If a string is longer 
than the other, append the additional letters onto the end of the merged string.

Return the merged string.

Example 1:

Input: word1 = "abc", word2 = "pqr"
Output: "apbqcr"
Explanation: The merged string will be merged as so:
word1:  a   b   c
word2:    p   q   r
merged: a p b q c r
Example 2:

Input: word1 = "ab", word2 = "pqrs"
Output: "apbqrs"
Explanation: Notice that as word2 is longer, "rs" is appended to the end.
word1:  a   b 
word2:    p   q   r   s
merged: a p b q   r   s
Example 3:

Input: word1 = "abcd", word2 = "pq"
Output: "apbqcd"
Explanation: Notice that as word1 is longer, "cd" is appended to the end.
word1:  a   b   c   d
word2:    p   q 
merged: a p b q c   d
*/

using System;

namespace MergeStringsAlternately
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1 = "abc", w2 = "pqr";
            var res = MergeAlternately(w1, w2);
            Console.WriteLine(res);
        }

        private static  string MergeAlternately(string w1, string w2)
        {
            string merged = "";
            int len1 = w1.Length, len2 = w2.Length;

            for(int i=0; i<len1; i++)
            {
                merged+= w1[i];
                if(len2>i)
                    merged+=w2[i];
            }

            if(len2>len1)
                merged+=w2.Substring(len1);
            return merged;
        }
    }
}
