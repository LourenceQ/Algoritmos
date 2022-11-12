﻿/*
202. Happy Number
Easy
Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the sum of the squares
of its digits.
Repeat the process until the number equals 1 (where it will stay), 
or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.

Example 1:

Input: n = 19
Output: true
Explanation:
12 + 92 = 82
82 + 22 = 68
62 + 82 = 100
12 + 02 + 02 = 1
Example 2:

Input: n = 2
Output: false
 

Constraints:

1 <= n <= 231 - 1
*/

using System;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            var res = IsHappy(n);
            Console.WriteLine(res);
        }

        private static bool IsHappy(int n)
        {
            int slowRunner = n;
            int fastRunner = getNext(n);

            while(fastRunner != 1 && slowRunner != fastRunner)
            {
                slowRunner = getNext(slowRunner);

                fastRunner = getNext(getNext(fastRunner));
            }
            return fastRunner == 1;
        }

        public static int getNext(int n)
        {
            int totalSum = 0;

            while(n > 0)
            {
                int d = n % 10;
                n = n /10;
                totalSum += d *d;
            }
            return totalSum;
        }
    }
}
