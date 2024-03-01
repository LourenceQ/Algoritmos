namespace TwoSumAlgorithm;
public static class TwoSum
{
    public static int[] Validate(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }

        return new int[2];
    }
}
