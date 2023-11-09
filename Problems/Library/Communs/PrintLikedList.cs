using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Library.Communs
{
    internal static class PrintLikedList
    {
        public static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current.next != null)
            {
                Console.WriteLine(current.val);
                current = current.next;
            }
            if (current.next == null) Console.WriteLine(current.val);
        }
    }
}
