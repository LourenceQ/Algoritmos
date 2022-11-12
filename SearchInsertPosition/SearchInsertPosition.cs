
/*
35. Search Insert Position
Easy

Given a sorted array of distinct integers and a target value, return the index if 
the target is found. If not, return the index where it would be if it were inserted 
in order.

You must write an algorithm with O(log n) runtime complexity. 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104
*/
namespace SearchInsertPosition
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int[] nums = {1,3,5,6};
            // int target = 5;

            int[] nums = { 1, 3, 5, 6 };
            int target = 0;

            // int[] nums = {1,3,5,6};
            // int target = 7;
            SearchInsert3(nums, target);

        }

        public static int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    System.Console.WriteLine(i);
                    return i;
                }
            }

            System.Console.WriteLine(nums.Length);
            return nums.Length;
        }

        public int SearchInsert2(int[] nums, int target)
        {
            var lo = 0;
            var hi = nums.Length - 1;

            while (hi - lo >= 0)
            {
                var mid = (hi + lo) / 2;

                if (nums[mid] == target) { return mid; }

                else if (nums[mid] < target) { lo = mid + 1; }

                else if (nums[mid] > target) { hi = mid - 1; }
            }
            return lo;

        }

        public static int SearchInsert3(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
                return -1;

            int i = 0,
                j = nums.Length - 1;

            while (i <= j)
            {
                int m = j + (i - j) / 2;

                if (nums[m] == target)
                    return m;
                else if (nums[m] < target)
                    i = m + 1;
                else
                    j = m - 1;
            }

            return i;
        }

    }
}
