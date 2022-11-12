/*
61. Rotate List
Medium
Given the head of a linked list, rotate the list to the right by k places.

Example 1:

Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]
Example 2:

Input: head = [0,1,2], k = 4
Output: [2,0,1]

Constraints:

The number of nodes in the list is in the range [0, 500].
-100 <= Node.val <= 100
0 <= k <= 2 * 109
*/
using System;
using System.Collections.Generic;

namespace RotateList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public ListNode RotateRight(ListNode head, int k)
        {
            if (k == 0) return head;

            List<ListNode> list = new List<ListNode>();

            var node = head;

            while (node != null)
            {
                list.Add(node);
                node = node.next;
            }

            if(list.Count == 0 || ((k %= list.Count) == 0)) return head;

            list[list.Count -1 ].next = list[0];
            list[list.Count - 1 - k].next = null;

            return list[list.Count - k];
            
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
