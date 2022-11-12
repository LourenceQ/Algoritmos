/*
287. Find the Duplicate Number
Medium
Given an array of integers nums containing n + 1 integers where each integer is 
in the range [1, n] inclusive.

There is only one repeated number in nums, return this repeated number.

You must solve the problem without modifying the array nums and uses only constant 
extra space.

Example 1:

Input: nums = [1,3,4,2,2]
Output: 2
Example 2:

Input: nums = [3,1,3,4,2]
Output: 3
 

Constraints:

1 <= n <= 105
nums.length == n + 1
1 <= nums[i] <= n
All the integers in nums appear only once except for precisely one integer which 
appears two or more times.
*/
using System;

namespace FindTheDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 2, 2 };
            var res = FindDuplicate(nums);
            Console.WriteLine(res);
        }

        private static int FindDuplicate(int[] nums)
        {
            int res = -1;
            int init = 0, end = nums.Length - 1;

            while (init <= end)
            {
                int mid = (init + end) / 2;

                int count = 0;

                foreach (var num in nums)
                {
                    if (num <= mid) { count++; }
                }

                if (count > mid)
                {
                    res = mid;
                    end = mid - 1;
                }
                else
                {
                    init = mid + 1;
                }
            }
            return res;
        }
    }
}
