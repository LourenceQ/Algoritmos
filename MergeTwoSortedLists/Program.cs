namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode list1 = new ListNode();
            ListNode list2 = new ListNode();
            MainSolution mainSolution = new MainSolution();

            mainSolution.MergeTwoLists(list1, list2);
        }
    }
}
