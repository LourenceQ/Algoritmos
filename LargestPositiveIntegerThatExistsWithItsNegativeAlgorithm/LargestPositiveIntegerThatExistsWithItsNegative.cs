namespace LargestPositiveIntegerThatExistsWithItsNegativeAlgorithm;

public class LargestPositiveIntegerThatExistsWithItsNegative
{
    public static int Validate(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return -1;
        }

        Array.Sort(nums);

        int i = 0;
        int j = nums.Length - 1;

        while (i < j)
        {
            if (nums[i] + nums[j] == 0)
            {
                return nums[j];
            }
            else if (nums[i] + nums[j] > 0)
            {
                j--;
            }
            else
            {
                i++;
            }
        }

        return -1;
    }
}
