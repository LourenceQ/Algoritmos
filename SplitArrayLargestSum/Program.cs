/*
410. Split Array Largest Sum
Hard
Given an array nums which consists of non-negative integers and an 
integer m, you can split the array into m non-empty continuous subarrays.

Write an algorithm to minimize the largest sum among these m subarrays.

Example 1:

Input: nums = [7,2,5,10,8], m = 2
Output: 18
Explanation:
There are four ways to split nums into two subarrays.
The best way is to split it into [7,2,5] and [10,8],
where the largest sum among the two subarrays is only 18.
Example 2:

Input: nums = [1,2,3,4,5], m = 2
Output: 9
Example 3:

Input: nums = [1,4,4], m = 3
Output: 4
 

Constraints:

1 <= nums.length <= 1000
0 <= nums[i] <= 106
1 <= m <= min(50, nums.length)
*/

using System;

namespace SplitArrayLargestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {7,2,5,10,8};
            int m = 2;
            var res = SplitArray(nums, m);
            Console.WriteLine(res);
        }
        
        public static int SplitArray(int[] nums, int m)
        {
            int l = 0, r = 0;
            foreach (var num in nums)
            {
                l = Math.Max(l, num);
                r += num;
            }

            while (l < r)
            {
                int mid = (r - l) / 2 + l;

                if(canSplit(nums, mid, m)) r = mid;

                else l = mid+1;
            }

            return l;
        }

        private static bool canSplit(int[] nums, int maxSum, int m)
        {
            int nOfSubArr = 1, currSum = 0;
            foreach (var n in nums)
            {
                if(currSum + n > maxSum)
                {
                    nOfSubArr++;
                    currSum = 0;
                }

                currSum += n;

                if(nOfSubArr > m) return false;
            }

            return true;
        }
    }
}

