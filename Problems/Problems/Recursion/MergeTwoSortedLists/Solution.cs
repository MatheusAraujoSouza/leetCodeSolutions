using Problems.Library.Communs;

namespace Problems.Problems.Recursion.MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            if (list2 == null)
                return list1;

            if (IsSingleZeroNode(list1) && IsSingleZeroNode(list2))
                return list1;

            var list = UnionTwoLikedList(list1, list2);
            return MergeSort(list);
        }

        private bool IsSingleZeroNode(ListNode list)
        {
            return list != null && list.next == null && list.val == 0;
        }

        private ListNode UnionTwoLikedList(ListNode list1, ListNode list2)
        {
            var currentList = list1;
            while (currentList.next != null)
            {
                currentList = currentList.next;
            }

            currentList.next = list2;
            return list1;
        }

        private ListNode MergeSort(ListNode list)
        {
            if (list == null || list.next == null) return list;

            var middle = FindMiddle(list);
            var nextToMiddle = middle.next;
            middle.next = null;

            ListNode left = MergeSort(list);
            ListNode right = MergeSort(nextToMiddle);

            return Merge(left, right);
        }

        private ListNode FindMiddle(ListNode head)
        {
            if (head == null)
                return null;

            ListNode slow = head, fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }  

        private ListNode Merge(ListNode left, ListNode right)
        {
            var dummy = new ListNode();
            var current = dummy;

            while (left != null && right != null)
            {
                if (left.val < right.val)
                {
                    current.next = left;
                    left = left.next;
                }
                else
                {
                    current.next = right;
                    right = right.next;
                }
                current = current.next;
            }

            if (left != null)
                current.next = left;

            if (right != null)
                current.next = right;

            return dummy.next;
        }
    }
}
