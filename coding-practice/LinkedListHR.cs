using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int newData)
        {
            data = newData;
            next = null;
        }

        public Node(int newData, Node newNext)
        {
            data = newData;
            next = newNext;

        }

        public int getData()
        {
            return data;
        }

        public void setData(int newData)
        {
            data = newData;
        }

        public Node getNext()
        {
            return next;
        }

        public void setNext(Node newNext)
        {
            next = newNext;
        }
    }

    public class LinkedList
    {
        // Properties
        public Node head;
        public int count;

        // Constructors
        public LinkedList()
        {
            head = null;
            count = 0; // need to know when we're at the end of a list
        }
        public LinkedList(Node newHead)
        {
            head = newHead;
            count = 1;
        }

        // Methods

        //add
        public void add(int newData)
        {
            Node temp = new Node(newData);
            // Handle case where list is empty
            if (head == null)
            {
                head = temp;
                count++;
                return;
            }
            // List is NOT empty
            Node current = head;
            while (current.getNext() != null)
            {
                current = current.getNext();
            }
            current.setNext(temp);
            count++;
        }

        //get
        public int get(int index)
        {
            if (index <= 0)
            {
                return -1;
            }
            Node current = head;
            for (int i = 1; i < index; i++)
            {
                if (current.getNext() == null)
                {
                    return -1;
                }
                current = current.getNext();
            }
            return current.getData();
        }

        //size
        public int size()
        {
            return count;
        }

        //isEmpty
        public bool isEmpty()
        {
            return head == null;
        }

        //remove
        public void remove()
        {
            if (head == null)
                return;
            Node current = head;
            // looking for last node (=null) then setting current to the second to last, and setting next to null.
            while (current != current.getNext().getNext() != null) 
            {
                current = current.getNext();
            }
            current.setNext(null);
            count--;
        }

    }

}
