/*
268. Missing Number
Easy
Given an array nums containing n distinct numbers in the range [0, n], return 
the only number in the range that is missing from the array.

 

Example 1:

Input: nums = [3,0,1]
Output: 2
Explanation: n = 3 since there are 3 numbers, so all numbers are in the 
range [0,3]. 2 is the missing number in the range since it does not appear in nums.
Example 2:

Input: nums = [0,1]
Output: 2
Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 
is the missing number in the range since it does not appear in nums.
Example 3:

Input: nums = [9,6,4,2,3,5,7,0,1]
Output: 8
Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 
is the missing number in the range since it does not appear in nums.
 

Constraints:

n == nums.length
1 <= n <= 104
0 <= nums[i] <= n
All the numbers of nums are unique.
 

Follow up: Could you implement a solution using only O(1) extra space complexity and O(n) 
runtime complexity?
*/
using System;
using System.Collections.Generic;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1º ordernar 
            2º somar o primeiro elemento +1
            3º comparar o elemento somado com o proximo
            4º caso negativo retornar elemento +1
            */
            int[] nums = {9,6,4,2,3,5,7,0,1};
            MissingNumber(nums);
        }

        public static int MissingNumber(int[] nums)
        {
            int num = 0;
            int totalSum = 0;
            int len = nums.Length;

            for (int i = 0; i < nums.Length; i++)
            {
                num += nums[i];        
            }
            totalSum = (len * (len+1))/2;
            return totalSum - num;
        }

        // public static int MisingNumebr(int[] nums)
        // {
        //     int num = 0;
        //     List<int> numsList = new List<int>();
        //     numsList.AddRange(nums);
        //     numsList.Sort();

        //     for (int i = 0; i < nums.Length; i++)
        //     {   
        //         System.Console.WriteLine(numsList[i]);
        //         // numsList.Add()
        //         // if(numsList[i] -1 != numsList[-1]) 
        //         // {
        //         //     num = numsList[i];                    
        //         // } 37

        //     } 
        //     System.Console.WriteLine();
        //     System.Console.WriteLine(num+1);          
        //     return num;
        // }
    }
}
