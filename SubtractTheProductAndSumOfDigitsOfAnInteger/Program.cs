/*
1281. Subtract the Product and Sum of Digits of an Integer
Easy

Given an integer number n, return the difference between the product of its digits and the sum of its digits.
 
Example 1:

Input: n = 234
Output: 15 
Explanation: 
Product of digits = 2 * 3 * 4 = 24 
Sum of digits = 2 + 3 + 4 = 9 
Result = 24 - 9 = 15
Example 2:

Input: n = 4421
Output: 21
Explanation: 
Product of digits = 4 * 4 * 2 * 1 = 32 
Sum of digits = 4 + 4 + 2 + 1 = 11 
Result = 32 - 11 = 21
 
Constraints:

1 <= n <= 10^5
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace SubtractTheProductAndSumOfDigitsOfAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            var res = SubtractProductAnsSum(n);
            Console.WriteLine(res);
        }

        public static int SubtractProductAnsSum(int n)
        {
            int mult = 1, sum = 0;

            List<int> digits = new List<int>();

            if (n == 0) return 0;

            while (n > 0)
            {
                var digit = n % 10;
                n /= 10;
                digits.Add(digit);
            }

            for (int x = 0; x < digits.Count; x++)
            {
                mult *= digits[x];
                sum += digits[x];
            }

            return mult - sum;
        }

        public static int SubtractProductAnsSum2(int n)
        {
            var digits = GetDigits(n);
            var produtct = digits.Aggregate(1, (x, y) => x * y);
            var sum = digits.Aggregate(0, (x, y) => x + y);

            return produtct - sum;

            List<int> GetDigits(int i)
            {
                if (i == 0) return new List<int> { 0 };
                var list = new List<int>();

                while (i > 0)
                {
                    list.Add(1 % 10);
                    i /= 10;
                }
                return list;
            }
        }

        public int SubtractProductAndSum3(int n)
        {

            string nString = n.ToString();
            int sSum = 0;
            int sProd = 1;
            int sTotal = 0;

            foreach (char x in nString)
            {

                sSum += Convert.ToInt32(x.ToString());
                sProd *= Convert.ToInt32(x.ToString());

            }

            sTotal = sProd - sSum;

            return sTotal;

        }
    }
}
