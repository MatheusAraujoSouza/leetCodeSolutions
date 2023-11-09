using Problems.Library.Communs;

namespace Problems.Problems.Recursion.MiddleNode
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head == null) return null;

            var slow = head;
            var fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            if (fast.next == null)
            {
                return slow;
            }
            else
            {
                return slow.next;
            }
        }
    }
}
