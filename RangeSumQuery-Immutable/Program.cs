/*
303. Range Sum Query - Immutable
Easy
Given an integer array nums, handle multiple queries of the following type:

Calculate the sum of the elements of nums between indices left and right inclusive where
 left <= right.
Implement the NumArray class:

NumArray(int[] nums) Initializes the object with the integer array nums.
int sumRange(int left, int right) Returns the sum of the elements of nums between indices
 left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
 

Example 1:

Input
["NumArray", "sumRange", "sumRange", "sumRange"]
[[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
Output
[null, 1, -1, -3]

Explanation
NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
 

Constraints:

1 <= nums.length <= 104
-105 <= nums[i] <= 105
0 <= left <= right < nums.length
At most 104 calls will be made to sumRange.
*/
using System;

namespace RangeSumQuery_Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { -2, 0, 3, -5, 2, -1 };
            NumArray obj = new NumArray(nums);
            int left = 0, right = 2;
            int param_1 = obj.SumRange(left, right);
        }

    }

    /*
    * Your NumArray object will be instantiated and called as such:
    * NumArray obj = new NumArray(nums);
    * int param_1 = obj.SumRange(left,right);
    */
    public class NumArray
    {
        int[] nums;
        int[] sums;
        int len;
        public NumArray(int[] nums)
        {
            this.nums = nums;
            len = nums.Length;
            sums = new int[len];
        }

        public int SumRange(int left, int right)
        {
            for (int i = 0; i < len; i++)
            {
                if (i == 0)
                {
                    sums[i] = nums[i];
                }
                else
                {
                    sums[i] = sums[i - 1] + nums[i];
                }
            }

            if (left == 0)
            {
                System.Console.WriteLine(sums[right]);
                return sums[right];
            }
            else
            {
                int sum = sums[right] - sums[left - 1];
                System.Console.WriteLine(sum);
                return sum;
            }
            

        }
    }
}
