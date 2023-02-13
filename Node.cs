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
        public bool Search(int data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                    return true;
                t = t.next;
            }
            return false;
        }
    }
}
