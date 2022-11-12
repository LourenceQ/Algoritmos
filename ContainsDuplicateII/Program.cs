/*
219. Contains Duplicate II
Given an integer array nums and an integer k, return true if 
there are two distinct indices i and j in the array such that
 nums[i] == nums[j] and abs(i - j) <= k.

Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
0 <= k <= 105
*/
using System.Collections.Generic;

namespace ContainsDuplicateII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,3,1};
            int k = 3;

            // int[] nums = {1,0,1,1};
            // int k = 1;

            // int[] nums = {1,2,3,1,2,3};
            // int k = 1;

            ContainsNearbyDuplicate(nums, k);

        }
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) && i - dict[nums[i]] <= k)
                    return true;
                dict[nums[i]] = i;
            }
            return false;
        }
    }
}
