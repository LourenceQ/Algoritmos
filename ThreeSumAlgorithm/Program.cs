﻿namespace ThreeSumAlgorithm;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] nums = [-1, 0, 1, 2, -1, -4];
        ThreeSum(nums);
    }

    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        List<IList<int>> res = [];
        if (nums == null || nums.Length < 3)
            return res;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] > 0 || (i > 0 && nums[i] == nums[i - 1]))
                continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                if (nums[i] + nums[left] + nums[right] == 0)
                {
                    res.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
                        left++;

                    while (left < right && nums[right] == nums[right + 1])
                        right--;

                }
                else if (nums[i] + nums[left] + nums[right] > 0)
                    right--;
                else
                    left++;
            }
        }

        return res;
    }
}
