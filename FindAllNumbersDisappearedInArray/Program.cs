/*
448. Find All Numbers Disappeared in an Array
Easy
Given an array nums of n integers where nums[i] is in the range [1, n], 
return an array of all the integers in the range [1, n] that do not appear in nums.

Example 1:

Input: nums = [4,3,2,7,8,2,3,1]
Output: [5,6]
Example 2:

Input: nums = [1,1]
Output: [2] 

Constraints:

n == nums.length
1 <= n <= 105
1 <= nums[i] <= n

Follow up: Could you do it without extra space and in O(n) runtime? You may assume 
the returned list does not count as extra space.
*/

using System;
using System.Collections.Generic;

namespace FindAllNumbersDisappearedInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            var res = FindDisappearedNumbers(nums);
            Console.WriteLine(res);
        }
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {

            //return Enumerable.Range(1,nums.Length).Except(nums).ToList();

            IList<int> res = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int val = Math.Abs(nums[i]);
                nums[val - 1] = -Math.Abs(nums[val - 1]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    res.Add(i + 1);
                }
            }

            return res;

        }
    }
}
