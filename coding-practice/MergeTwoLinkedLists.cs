using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    public class MergeTwoLinkedLists
    {
        public static ListNode MergeTwoListsRecursive(ListNode list1, ListNode list2)
        {
            if (list1 == null) return (list2);
            if (list2 == null) return (list1);

            var head = new ListNode();

            if (list1.val < list2.val)
            {
                head = list1;
                list1 = list1.next;
            }
            else
            {
                head = list2;
                list2 = list2.next;
            }
            head.next = MergeTwoListsRecursive(list1, list2);

            return head;

            // time: O(m + n), space: O(m + n) -proportional to num of stack frames
        }

        public static ListNode MergeTwoListsIterative(ListNode list1, ListNode list2)
        {
            ListNode head = new ListNode();
            ListNode tail = head;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
            }
            tail.next = list1 ?? list2;

            return head.next;
        }
    }



}
