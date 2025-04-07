using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    public class LinkedListNode
    {
        public ListNode? head = null;
        public int length = 0;
        public LinkedListNode()
        {

        }
        public LinkedListNode(int value)
        {
            head = new ListNode(value);
            head.next = null;
            length++;
        }
        public void PrintLL()
        {
            if (this.head == null)
                Console.WriteLine("Nothing to Print");
            var currentNode = head;
            while (currentNode.next != null)
            {
                Console.WriteLine(currentNode.val);
                currentNode = currentNode.next;
            }
            Console.WriteLine(currentNode.val);

        }
        public void Append(int value)
        {
            if (this.head == null)
            {
                head = new ListNode(value);
                head.next = null;
                length++;
                return;
            }

            var newNode = new ListNode(value);
            var currentNode = this.head;
            while (currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            currentNode.next = newNode;
            currentNode.next.next = null;
        }

        public void PrePend(int value)
        {
            var newNode = new ListNode(value);
            newNode.next = this.head;
        }
        public void Insert(int index, int value)
        {
            var newNode = new ListNode(value);
            var leader = TraverseToIndex(index - 1);
            var holdingPointer = leader.next;
            leader.next = newNode;
            newNode.next = holdingPointer;
        }

        public ListNode TraverseToIndex(int index)
        {
            var counter = 0;
            var currentNode = this.head;
            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }
    }

}
