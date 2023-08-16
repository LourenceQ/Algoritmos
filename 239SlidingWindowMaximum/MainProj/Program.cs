/*
239. Sliding Window Maximum
Hard
16.6K
558
Companies
You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.

Return the max sliding window.

 

Example 1:

Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
Output: [3,3,5,5,6,7]
Explanation: 
Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7
Example 2:

Input: nums = [1], k = 1
Output: [1]
 

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
1 <= k <= nums.length
*/
namespace MainProj;

public static class Program
{
    public static void Main(string[] args)
    {
        int[] nums = new int[] {1,3,-1,-3,5,3,6,7};
        int k = 3;

        int[] res = MaxSlidingWindow(nums, k);
    }    

    public static int[] MaxSlidingWindow(int[] nums, int k) 
    {
        LinkedList<int> queue = new LinkedList<int>();
        List<int> res = new List<int>();

        for(int i=0; i<nums.Length; i++)
        {
            while(queue.Count>0 && queue.First.Value  < 1-k+1)
            {
                queue.RemoveFirst();
            }

            var currentVal = nums[i];

            while (queue.Count>0 && nums[queue.Last.Value] < currentVal)
            {
                queue.RemoveLast();
            }

            queue.AddLast(i);

            if(i >= k-1)
            {
                res.Add(nums[queue.First.Value]);
            }
        }

        return res.ToArray();
        
    }
}