/*
169. Majority Element
Given an array nums of size n, return the majority element.

The majority element is the element that appears more than 
⌊n / 2⌋ times. You may assume that the majority element always 
exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-231 <= nums[i] <= 231 - 1
*/
using System.Collections.Generic;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            MajorityElement(nums);
        }

        public static int MajorityElement(int[] nums) {
        Dictionary<int, int> counter = new Dictionary<int, int>();
        int threshhold = nums.Length / 2;
        foreach(int i in nums)
        {
            if(!counter.ContainsKey(i))
            {
                counter.Add(i, 1);
            }
            else
            {
                counter[i]++;
            }
            
            if(counter[i] > threshhold)
            {
                return i;
            }
        }
        return 0;
    }

        public static int MajorityElement2(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic.Add(num, 1);

                if (dic[num] > nums.Length / 2)
                    return num;
            }

            return -1;
        }
    }
}