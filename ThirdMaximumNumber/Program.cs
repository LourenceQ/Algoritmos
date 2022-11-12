/*
414. Third Maximum Number
Easy
Given an integer array nums, return the third distinct maximum number in this array. 
If the third maximum does not exist, return the maximum number.

Example 1:

Input: nums = [3,2,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2.
The third distinct maximum is 1.
Example 2:

Input: nums = [1,2]
Output: 2
Explanation:
The first distinct maximum is 2.
The second distinct maximum is 1.
The third distinct maximum does not exist, so the maximum (2) is returned instead.
Example 3:

Input: nums = [2,2,3,1]
Output: 1
Explanation:
The first distinct maximum is 3.
The second distinct maximum is 2 (both 2's are counted together since they have the same value).
The third distinct maximum is 1.
 
Constraints:

1 <= nums.length <= 104
-231 <= nums[i] <= 231 - 1
*/

using System.Collections.Generic;
using System.Linq;

namespace ThirdMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 3, 16, 7, 4, 90, 4, 60 };
            ThirdMax(nums);

        }
        public static int ThirdMax(int[] nums)
        {
            long max = nums[0], max2nd = long.MinValue, max3rd = long.MinValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max3rd = max2nd;
                    max2nd = max;
                    max = nums[i];
                }
                else if (nums[i] > max2nd)
                {
                    if (nums[i] != max)
                    {
                        max3rd = max2nd;
                        max2nd = nums[i];
                    }
                }
                else if (nums[i] > max3rd)
                    if (nums[i] != max2nd)
                        max3rd = nums[i];
            }

            return (int)(max3rd != long.MinValue ? max3rd : max);
        }

        public static int ThirdMax2(int[] nums)
        {
            int maior = nums[0], sMaior = 0, tMaior = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maior)
                    tMaior = sMaior;
                sMaior = maior;
                maior = nums[i];

                if (nums[i] > sMaior)
                    if (nums[i] != maior)
                        tMaior = sMaior;
                sMaior = nums[i];

                if (nums[i] > tMaior)
                    if (nums[i] != sMaior)
                        tMaior = nums[i];
            }

            return tMaior;



            // int maior = 0, sMaior = 0, tMaior = 0;

            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (nums[i] > maior)
            //         maior = nums[i];
            // }
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (nums[i] < maior)
            //         sMaior = nums[i];
            // }
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (nums[i] < sMaior)
            //         tMaior = nums[i];
            // }

            // return tMaior;
        }

        public static int ThirdMax3(int[] nums)
        {
            HashSet<int> maxNums = new HashSet<int>(3);

            for (int i = 0; i < nums.Length; i++)
            {
                if (!maxNums.Contains(nums[i]))
                {
                    // Add max numbers
                    if (maxNums.Count == 0 || maxNums.Count < 3)
                    {
                        maxNums.Add(nums[i]);
                    }
                    else if (nums[i] > maxNums.Min())
                    // If we reached 3 max numbers replace the smallest
                    {
                        maxNums.Remove(maxNums.Min());
                        maxNums.Add(nums[i]);
                    }
                }
            }

            if (maxNums.Count < 3)
            {
                return maxNums.Max();
            }
            else
            {
                return maxNums.Min();
            }
        }
    }
}


