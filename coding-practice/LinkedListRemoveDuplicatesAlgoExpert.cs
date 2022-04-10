using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
	public class LinkedListAlgoExpert
	{
		public int value;
		public LinkedListAlgoExpert next;

		public LinkedListAlgoExpert(int value)
		{
			this.value = value;
			this.next = null;
		}
	}

    public class LinkedListAlgoExpertSolution
    {
        public static LinkedListAlgoExpert Solution(LinkedListAlgoExpert head, int k)
        {
            LinkedListAlgoExpert current = head;
            LinkedListAlgoExpert previous = null;
            int count = 0;
            while (current != null)
            {
                if (count == k)
                {
                    previous.next = current.next;
                    break;
                }
                count++;
                previous = current;
                current = current.next;
            }
            return head;
        }
		public LinkedListAlgoExpert RemoveDuplicatesFromLinkedList(LinkedListAlgoExpert linkedList)
		{
			var currentNode = linkedList;

			while (currentNode != null)
			{
				var nextDistinctNode = currentNode.next;
				while (nextDistinctNode != null &&
				nextDistinctNode.value == currentNode.value)
				{
					nextDistinctNode = nextDistinctNode.next;
				}
				currentNode.next = nextDistinctNode;
				currentNode = nextDistinctNode;
			}
			return linkedList;
		}
	}
}
