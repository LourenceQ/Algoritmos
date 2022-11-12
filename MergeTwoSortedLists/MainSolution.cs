using MergeTwoSortedLists;

public class MainSolution : ListNode
{
    public static ListNode insert(ListNode root, int item)
    {
        ListNode temp = new ListNode();
        ListNode ptr;
        temp.val = item;
        temp.next = null;

        if (root == null)
            root = temp;
        else
        {
            ptr = root;
            while (ptr.next != null)
                ptr = ptr.next;
            ptr.next = temp;
        }
        return root;
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode c = null;
        ListNode temp = null;
        if (list1 == null && list2 == null)
            return null;
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                c = insert(c, list1.val);
                list1 = list1.next;
            }
            else
            {
                c = insert(c, list2.val);
                list2 = list2.next;
            }
        }
        if (list1 == null)
        {
            temp = c;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = list2;
        }

        if (list2 == null)
        {
            temp = c;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = list1;
        }
        return c;
    }
}