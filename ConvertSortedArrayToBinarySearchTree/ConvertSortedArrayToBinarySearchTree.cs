/*
108. Convert Sorted Array to Binary Search Tree
Given an integer array nums where the elements are sorted
in ascending order, convert it to a height-balanced binary 
search tree.

A height-balanced binary tree is a binary tree in which the depth 
of the two subtrees of every node never differs by more than one.

Example 1:

Input: nums = [-10,-3,0,5,9]
Output: [0,-3,9,-10,null,5]
Explanation: [0,-10,5,null,-3,null,9] is also accepted:

Example 2:


Input: nums = [1,3]
Output: [3,1]
Explanation: [1,3] and [3,1] are both a height-balanced BSTs.
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums is sorted in a strictly increasing order.
*/

namespace ConvertSortedArrayToBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3 };
            SortedArrayToBST(nums);
        }

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            return BuildTree(nums, 0, nums.Length - 1);
        }

        private static TreeNode BuildTree(int[] nums, int i, int j)
        {
            if (j < i)
                return null;

            int mid = j + (i - j) / 2;
            TreeNode node = new TreeNode(nums[mid]);

            node.left = BuildTree(nums, i, mid - 1);
            node.right = BuildTree(nums, mid + 1, j);

            return node;
        }

    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


}

// public TreeNode SortedArrayToBST(int[] nums)
// {
//     return ToBst(0, nums.Length - 1);

//     TreeNode ToBst(int left, int right)
//     {
//         if (left > right) return null;

//         var middle = left + (right - left) / 2;
//         return new TreeNode(nums[middle])
//         {
//             left = ToBst(left, middle - 1),
//             right = ToBst(middle + 1, right)
//         };
//     }
// }
