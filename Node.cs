using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int input)
        {
            data = input;
        }
    }
    internal class List
    {
        private Node head;
        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
    }
}
