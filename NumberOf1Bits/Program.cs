/*
191. Number of 1 Bits
Easy
Write a function that takes an unsigned integer and returns the number of '1' 
bits it has (also known as the Hamming weight).

Note:

Note that in some languages, such as Java, there is no unsigned integer type. In this 
case, the input will be given as a signed integer type. It should not affect your 
implementation, as the integer's internal binary representation is the same, whether 
it is signed or unsigned.
In Java, the compiler represents the signed integers using 2's complement notation. 
Therefore, in Example 3, the input represents the signed integer. -3.
 

Example 1:

Input: n = 00000000000000000000000000001011
Output: 3
Explanation: The input binary string 00000000000000000000000000001011 has a total of 
three '1' bits.
Example 2:

Input: n = 00000000000000000000000010000000
Output: 1
Explanation: The input binary string 00000000000000000000000010000000 has a total of 
one '1' bit.
Example 3:

Input: n = 11111111111111111111111111111101
Output: 31
Explanation: The input binary string 11111111111111111111111111111101 has a total of 
thirty one '1' bits.
 

Constraints:

The input must be a binary string of length 32.
 

Follow up: If this function is called many times, how would you optimize it?
*/

using System;
using System.Linq;

namespace NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 00000000000000000000000000001011;

            var res = HammingWeight(n);
            System.Console.WriteLine(res);
        }

        public static int HammingWeight(uint n)
        {

            // return Convert.ToString(n,2).Replace("0", "").Length;
            int res = 0;

            while (n != 0)
            {
                if (n % 2 != 0)
                {
                    res++;
                    n >>= 1;
                }
            }
            return res;
            // int count = 0;

            // string a = n.ToString();
            // foreach (var item in a)
            // {
            //     if (item == '1')
            //     {
            //         count = count + 1;
            //     }
            // }
            // System.Console.WriteLine(count);
            // return count;
        }

        public int HammingWeight2(uint n)
        {
            int res = 0;

            while (n != 0)
            {
                uint cur = n;

                if ((cur & 1) == 1)
                    res++;

                n = n >> 1;
            }

            return res;
        }

        public int HammingWeight3(uint n)
        {
            int count = 0;

            while (n != 0)
            {
                if ((n & (~n + 1)) == 1)
                    count++;

                n = n >> 1;
            }

            return count;
        }

        public static int HammingWeight4(uint n)
        {

            return Convert.ToString(n, 2).Select(x => x).Where(x => x == '1').Count();
        }

        public static int HammingWeight5(uint n)
        {
            return Convert.ToString(n,2).Count(c=> c=='1');
        }
    }
}
