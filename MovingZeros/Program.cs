/*
283. Move Zeroes
Easy
Given an integer array nums, move all 0's to the end of it while maintaining the
relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]
 

Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
*/

using System;

namespace MovingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
        }

        public static void MoveZeroes(int[] nums)
        {
            int end = nums.Length;
            for (int i = 0; i < end; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < end - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[end - 1] = 0;
                    end--;
                    i--;
                }

            }

            for (int i = 0; i < nums.Length; i++)
            {
                System.Console.WriteLine(nums[i]);
            }
        }
    }

}

