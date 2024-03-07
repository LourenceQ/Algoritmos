namespace SummaryRangesAlgorithm;

public static class SummaryRanges
{
    public static IList<string> Validate(int[] nums)
    {
        IList<string> str = [];

        if (nums.Length == 0) return str;
        if (nums.Length == 1)
        {
            str.Add(nums[0].ToString());
            return str;
        }

        int start = nums[0], end = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] + 1 == nums[i])
            {
                end = nums[i];
            }
            else
            {
                if (start != end)
                {
                    str.Add(start + "->" + end);
                }
                else
                {
                    str.Add(start.ToString());
                }
                start = nums[i];
                end = nums[i];
            }
        }

        if (start != end)
        {
            str.Add(start + "->" + end);
        }
        else
        {
            str.Add(start.ToString());
        }
        return str;
    }
}

