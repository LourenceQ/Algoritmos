﻿/*
389. Find the Difference
Easy
You are given two strings s and t.

String t is generated by random shuffling string s and then add one more letter 
at a random position.

Return the letter that was added to t. 

Example 1:

Input: s = "abcd", t = "abcde"
Output: "e"
Explanation: 'e' is the letter that was added.
Example 2:

Input: s = "", t = "y"
Output: "y"
 

Constraints:

0 <= s.length <= 1000
t.length == s.length + 1
s and t consist of lowercase English letters.
*/
using System;

namespace FindTheDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd", t = "abcde";
            var res = FindTheDifference1(s, t);
            Console.WriteLine(res);
        }

        private static  object FindTheDifference1(string s, string t)
        {
            var charAndCount = new int[256];
            foreach (var item in s)
            {
                charAndCount[item]++;
            }

            foreach (var item in t)
            {
                charAndCount[item]--;
            }

            for (int i = 0; i < 256; i++)
            {
                if(charAndCount[i] < 0) return (char)i;
            }
            throw new Exception("No difference");
        }
    }
}
