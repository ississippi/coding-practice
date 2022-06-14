using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class RecursionNurbo
    {



        //
        // 1. Given a string calculate length of the string using recursion. 
        //
        public int GetStringLength(string s)
        {
            return GetStringLengthHelper(s, 0);
        }
        private int GetStringLengthHelper(string s, int idx)
        {
            if (idx >= s.Length)
                return 0;
            return 1 + GetStringLengthHelper(s, idx + 1);
        }

        //
        // 2. Given a string, count the total number of consonants in it.
        //
        public int GetConsonantCount(string s)
        {
            return GetConsonantCountHelper(s, 0);
        }
        public int GetConsonantCountHelper(string s, int idx)
        {
            var vowels = "aeiou";
            if (idx >= s.Length)
                return 0;
            if (!vowels.Contains(s[idx]))
                return 1 + GetConsonantCountHelper(s, idx + 1);
            else
                return GetConsonantCountHelper(s, idx + 1);
        }

        //
        // 3. https://leetcode.com/problems/remove-linked-list-elements/
        // 203. Remove Linked List Elements
        // Given the head of a linked list and an integer val,
        // remove all the nodes of the linked list that has Node.val == val,
        // and return the new head.
        //
        // Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            var current = head;
            var newHead = head;
            while (current.next != null)
            {
                if (current.val == val)
                {
                    current.next = current.next.next;
                    if (current == head)
                        newHead = current.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return newHead;
        }
    }
}
