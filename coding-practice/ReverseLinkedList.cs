using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class ReverseLinkedList
    {


        // Definition for singly-linked list.
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
 
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }
    }

    public class MyLinkedList
    {
        public ListNode head;
        public ListNode tail;
        int _length = 0;
        public MyLinkedList(ListNode head)
        {
            head = head;
            head.next = null;
            tail = head;
            _length = 1;
        }
        public MyLinkedList Append(int value)
        {
            var newNode = new ListNode(value);
            tail.next = newNode;
            tail = newNode;
            _length++;
            return this;
        }
    }
}
