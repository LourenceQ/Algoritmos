/*
976. Largest Perimeter Triangle
Easy

Given an integer array nums, return the largest perimeter of a triangle with a 
non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

Example 1:

Input: nums = [2,1,2]
Output: 5
Example 2:

Input: nums = [1,2,1]
Output: 0

Constraints:

3 <= nums.length <= 104
1 <= nums[i] <= 106
*/
using System;

namespace LargestPerimeterTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5, soma = 0;

            int d = int.Parse(Console.ReadLine());

            if (d % 2 == 0)
            {
                while(i < 5)
                {
                    soma = soma + d;
                    d += 2;
                    i--;
                }
                System.Console.WriteLine(soma);
            }

            else if (d % 2 !=0)
            {
               d+=1;
               while(i <= 5)
               {
                   soma = soma + d;
                   d += 2;
                   i--;
               }
               System.Console.WriteLine(soma);
            }
            
        }

        public static int LargestPerimeter(int[] arr)
        {
            // Array.Sort(arr, (a1, a2) => a2.CompareTo(a1));
             Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
            for (int i = arr.Length - 2; i >= 0; --i)
            {

                if (arr[i] < arr[i - 1] + arr[i - 2])
                {
                    return arr[i] + arr[i - 1] + arr[i - 2];
                }
            }



            return 0;
        }

        public static int LargestPerimeter2(int[] arr)
        {
            Array.Sort(arr, (a1, a2) => a2.CompareTo(a1));
            // Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr.Length - 2; i++)
            {

                if (arr[i] < arr[i + 1] + arr[i + 2])
                {
                    return arr[i] + arr[i + 1] + arr[i + 2];
                }
            }

            return 0;
        }
    }
}
