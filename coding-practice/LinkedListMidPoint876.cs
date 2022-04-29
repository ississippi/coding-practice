using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class LinkedListMidPoint876
    {
        // 876. Middle of the Linked List
        public ListNode MiddleNode(ListNode head)
        {
            var nodes = new List<ListNode>();
            var current = head;
            while (current != null)
            {
                nodes.Add(current);
                current = current.next;
            }
            var midPoint = (nodes.Count / 2);
            return nodes[midPoint];
        }
    }
}
