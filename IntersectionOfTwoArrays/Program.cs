/*
349. Intersection of Two Arrays
Easy
Given two integer arrays nums1 and nums2, return an array of their intersection. 
Each element in the result must be unique and you may return the result in any order.

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.
 
Constraints:

1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntersectionOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            Intersection(nums1, nums2);
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> uniqueIntersects = new List<int>();
            var bigger = nums1.Length >= nums2.Length ? nums1 : nums2;
            var smaller = nums1.Length >= nums2.Length ? nums2 : nums1;

            foreach (var i in smaller)
            {
                foreach (var i1 in bigger)
                {
                    if (i == i1 && !uniqueIntersects.Contains(i))
                    {
                        uniqueIntersects.Add(i);
                    }
                }
            }

            return uniqueIntersects.ToArray();

            // var n1 = nums1.ToHashSet();
            // return nums2.Where(n1.Contains).Distinct().ToArray();

            /*
            if (nums1.Length == 0 || nums2.Length == 0)
                return new int[] { };

            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> final = new List<int>();
            if (nums1.Length < nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (!dict.ContainsKey(nums1[i]))                    
                        dict.Add(nums1[i], 1);                    
                }

                for (int i = 0; i < nums2.Length; i++)
                {
                    if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] != 0)                    
                        final.Add(nums2[i]);
                        dict[nums2[i]] -= 1;                    
                }
            }
            else
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    if (!dict.ContainsKey(nums2[i]))                    
                        dict.Add(nums2[i], 1);                    
                }

                for (int i = 0; i < nums1.Length; i++)
                {
                    if (dict.ContainsKey(nums1[i]) && dict[nums1[i]] != 0)                    
                        final.Add(nums1[i]);
                        dict[nums1[i]] -= 1;                    
                }
            }
            return final.ToArray(); */
        }
    }
}

