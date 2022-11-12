/*
1523. Count Odd Numbers in an Interval Range
Easy
Given two non-negative integers low and high. Return the 
count of odd numbers between low and high (inclusive).

Example 1:

Input: low = 3, high = 7
Output: 3
Explanation: The odd numbers between 3 and 7 are [3,5,7].
Example 2:

Input: low = 8, high = 10
Output: 1
Explanation: The odd numbers between 8 and 10 are [9].
*/
using System;

namespace CountOddNumbersInAnIntervalRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = 3, high = 7;
            CountOdds2(low, high);
        }

        public static int CountOdds(int low, int hight)
        {
            int countOdds = 0;
            for (int i = low; i <= hight; i++)
                if (i % 2 != 0)
                    countOdds++;
            System.Console.WriteLine(countOdds);
            return countOdds;
        }

        public static int CountOdds2(int low, int hight)
        {
            // => (hight + 1) / 2 - low / 2;
            var countOdds = ((hight + 1) / 2) - (low / 2);
            System.Console.WriteLine(countOdds);
            return countOdds;
        }

    }
}
