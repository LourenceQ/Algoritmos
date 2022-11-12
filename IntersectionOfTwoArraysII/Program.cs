/*
350. Intersection of Two Arrays II
Easy
Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in
 the result must appear as many times as it shows in both arrays and you may return the result 
 in any order.

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Explanation: [9,4] is also accepted. 

Constraints:

1 <= nums1.length, nums2.length <= 1000
0 <= nums1[i], nums2[i] <= 1000 

Follow up:

What if the given array is already sorted? How would you optimize your algorithm?
What if nums1's size is small compared to nums2's size? Which algorithm is better?
What if elements of nums2 are stored on disk, and the memory is limited such that you cannot 
load all elements into the memory at once?
*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace IntersectionOfTwoArraysII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 9, 4, 9, 8, 4 };
            int[] nums2 = { 4, 9, 5 };
            var a = Intersect(nums1, nums2);
            for (int i=0; i<a.Length;i++)
            {
                System.Console.WriteLine(a[i]);
            }

        }
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            int a = nums1.Length;
            int b = nums2.Length;

            List<int> aux = new List<int>();

            if (a > b)
            {
                List<int> newItems = nums1.ToList();
                for (int i = 0; i < b; i++)
                {
                    if (newItems.Contains(nums2[i]))
                        aux.Add(nums2[i]);
                    newItems.Remove(nums2[i]);
                }
            }
            else
            {
                List<int> newItems = nums2.ToList();
                for (int i = 0; i < a; i++)
                {
                    if (newItems.Contains(nums1[i]))
                        aux.Add(nums1[i]);
                    newItems.Remove(nums1[i]);
                }
            }
            return aux.ToArray();
        }
    }
}
