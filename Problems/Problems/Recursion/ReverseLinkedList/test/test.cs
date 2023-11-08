using Problems.Problems.Recursion.ReverseLinkedList.communs;

namespace Problems.Problems.Recursion.ReverseLinkedList.test
{
    internal static class Test
    {
        public static void testProblem()
        {
            ListNode head = new ListNode(1);
            ListNode secondNode = new ListNode(2);
            ListNode thirdNode = new ListNode(3);
            ListNode fourthNode = new ListNode(4);


            head.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;
            var mySolution = new Solution();

            mySolution.PrintList(head);
            Console.WriteLine("\n\n\n");
            mySolution.ReverseList(head);
            mySolution.PrintList(head);
        }
    }
}
