using Problems.Library.Communs;

namespace Problems.Problems.Recursion.ReverseLinkedList
{
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            var size = CountLinkedListElements(head);
            Reverse(head, 0, size - 1);
            return head;
        }


        private void Reverse(ListNode list, int initialPosition, int lastPosition)
        {
            if (initialPosition > lastPosition) return;
            var tempVariable = GetValueAtPosition(list, initialPosition);
            ChangeValueAtPosition(list, initialPosition, GetValueAtPosition(list, lastPosition));
            ChangeValueAtPosition(list, lastPosition, tempVariable);
            Reverse(list, initialPosition + 1, lastPosition - 1);
        }

        private int CountLinkedListElements(ListNode head)
        {
            int count = 0;
            ListNode current = head;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }


        private int GetValueAtPosition(ListNode head, int position)
        {
            int count = 0;
            ListNode current = head;

            while (current != null)
            {
                if (count == position)
                {
                    return current.val;
                }

                count++;
                current = current.next;
            }

            return int.MinValue;
        }

        public void PrintList(ListNode head)
        {
            ListNode current = head;
            while(current.next != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
            if (current.next == null) Console.WriteLine(current.val);
        }

        private void ChangeValueAtPosition(ListNode head, int position, int newValue)
        {
            int count = 0;
            ListNode current = head;

            while (current != null)
            {
                if (count == position)
                {
                    current.val = newValue;
                    return;
                }

                count++;
                current = current.next;
            }
        }

    }
}
