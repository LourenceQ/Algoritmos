namespace ThirdMaximumNumberAlgorithm;

public static class ThirdMaximumNumber
{
    public static int Validate(int[] nums)
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
}
