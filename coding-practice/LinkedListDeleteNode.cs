using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{

    // I was not able to solve this one, and no solution was given in LeetCode.
    // The problem is I can see no way to find the previous node in order to set it's next pointer to the 
    // node after the found value.
    // https://leetcode.com/problems/delete-node-in-a-linked-list/
    
    //237. Delete Node in a Linked List
    //Easy
    //3843
    //10950
    //Add to List
    //Share
    //Write a function to delete a node in a singly-linked list.You will not be given access to the head of the list, instead you will be given access to the node to be deleted directly.
    //It is guaranteed that the node to be deleted is not a tail node in the list.

    internal class LinkedListDeleteNode
    {
        ListNode head;
        public void DeleteNode(ListNode deleteMe)
        {
            ListNode next = deleteMe.next;
            ListNode prev = null;
            ListNode curr = deleteMe;
            Console.Write("entry...");
            while (curr != null)
            {
                Console.Write(curr.val);
                //if (curr.val != deleteMe.val)
                //{
                //    prev = curr;
                //}
                //else
                //{
                //    if (prev != null)
                //        prev.next = curr.next;
                //}
                curr = curr.next;
            }
        }
    }
}
