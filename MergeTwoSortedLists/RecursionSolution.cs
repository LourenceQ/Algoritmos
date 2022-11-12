using MergeTwoSortedLists;

public class RecursionSolution : ListNode
    {
       public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
                return null;

            if (list1 == null && list2 != null)
                return new ListNode(list2.val)
                {
                    next = MergeTwoLists(list1, list2.next)
                };
            if (list1 != null && list2 == null)
                return new ListNode(list1.val)
                {
                    next = MergeTwoLists(list1.next, list2)
                };

            if (list1.val < list2.val)
                return new ListNode(list1.val)
                {
                    next = MergeTwoLists(list1.next, list2)
                };

            return new ListNode(list2.val)
            {
                next = MergeTwoLists(list1, list2.next)
            };
        }
    }
