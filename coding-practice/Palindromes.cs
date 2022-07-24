using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
 // Definition for singly-linked list.
    internal class Palindromes
    {

        // Copy the LinkedList to an array, then copy the array in reverse to another array and compare.
        public bool isPalindrome(ListNode head)
        {
            if (head == null)
                return false;
            List<int> inputLL = new List<int>();
            var curr = head;
            while (curr != null)
            {
                inputLL.Add(curr.val);
                curr = curr.next;
            }

            List<int> revLL = new List<int>();
            for(int i = inputLL.Count - 1; i >= 0; i--)
            {
                revLL.Add(inputLL[i]);
            }

            for (int i = 0; i < inputLL.Count; i++)
            {
                if (inputLL[i] != revLL[i])
                    return false;
            }
            return true;
        }


    }
}
