using Problems.Library.Communs;

namespace Problems.Problems.Recursion.MergeTwoSortedLists.Test
{
    internal static class Test
    {
        public static void TestMerge()
        {
            ListNode head = new ListNode(1);
            ListNode secondNode = new ListNode(3);
            ListNode thirdNode = new ListNode(5);
            ListNode fourthNode = new ListNode(2);


            head.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            ListNode head2 = new ListNode(7);
            ListNode secondNode2 = new ListNode(8);
            ListNode thirdNode2 = new ListNode(9);
            ListNode fourthNode2 = new ListNode(4);


            head2.next = secondNode2;
            secondNode2.next = thirdNode2;
            thirdNode2.next = fourthNode2;

            var solution = new Solution();

            var list = solution.MergeTwoLists(head, head2);
            PrintLikedList.PrintList(list);
        }


        public static void TestMerge_With_zeros()
        {
            ListNode head = new ListNode();
            ListNode head2 = new ListNode();

            var solution = new Solution();

            var list = solution.MergeTwoLists(head, head2);
            PrintLikedList.PrintList(list);
        }


        public static void TestMerge_case_one()
        {
            ListNode head = new ListNode(1);
            ListNode secondNode = new ListNode(2);
            ListNode thirdNode = new ListNode(4);


            head.next = secondNode;
            secondNode.next = thirdNode;


            ListNode head2 = new ListNode(1);
            ListNode secondNode2 = new ListNode(3);
            ListNode thirdNode2 = new ListNode(4);
  


            head2.next = secondNode2;
            secondNode2.next = thirdNode2;

            var solution = new Solution();

            var list = solution.MergeTwoLists(head, head2);
            PrintLikedList.PrintList(list);
        }



    }
}
