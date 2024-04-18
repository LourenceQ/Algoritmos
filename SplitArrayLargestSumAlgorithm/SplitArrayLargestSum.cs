namespace SplitArrayLargestSumAlgorithm;

public class SplitArrayLargestSum
{
    public static int Validate(int[] nums, int m)
    {
        int l = 0, r = 0;
        foreach (var num in nums)
        {
            l = Math.Max(l, num);
            r += num;
        }

        while (l < r)
        {
            int mid = (r - l) / 2 + l;

            if (canSplit(nums, mid, m)) r = mid;

            else l = mid + 1;
        }

        return l;
    }

    private static bool canSplit(int[] nums, int maxSum, int m)
    {
        int nOfSubArr = 1, currSum = 0;
        foreach (var n in nums)
        {
            if (currSum + n > maxSum)
            {
                nOfSubArr++;
                currSum = 0;
            }

            currSum += n;

            if (nOfSubArr > m) return false;
        }

        return true;
    }
}
