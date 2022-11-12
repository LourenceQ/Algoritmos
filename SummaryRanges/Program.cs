
/*
You are given a sorted unique integer array nums.

Return the smallest sorted list of ranges that cover all the numbers in the array exactly. 
That is, each element of nums is covered by exactly one of the ranges, and there 
is no integer x such that x is in one of the ranges but not in nums.

Each range [a,b] in the list should be output as:

"a->b" if a != b
"a" if a == b
 

Example 1:

Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"
Example 2:

Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
 

Constraints:

0 <= nums.length <= 20
-231 <= nums[i] <= 231 - 1
All the values of nums are unique.
nums is sorted in ascending order.
*/

// C# | Simple Solution | Easy to Understand
using System.Collections.Generic;

namespace SummaryRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 2, 3, 4, 6, 8, 9 };
            SummaryRanges(nums);
        }

        public static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> str = new List<string>();

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
            
            // IList<string> str = new List<string>();

            // if(nums.Length == 0) return str;
            // if(nums.Length == 1)
            // {
            //     str.Add(nums[0].ToString());
            //     return str;
            // }

            // int start = nums[0], end = nums[0];
            // for (int i = 1; i < nums.Length; i++)
            // {
            //     if(nums[i-1] + 1 == nums[i])
            //     {
            //         end = nums[i];
            //     }
            //     else
            //     {
            //         str.Add(start != end ? start + "->" + end : start.ToString());
            //         start = nums[i];
            //         end = nums[i];
            //     }
            // }

            // str.Add(start != end ? start + "->" + end : start.ToString());
            // return str; 
        }
    }
}
