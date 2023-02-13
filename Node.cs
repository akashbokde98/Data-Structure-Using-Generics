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
        public bool Insert(int ind, int data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)// 2 
            {
                ind--;//0
                pre = t;// 
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            throw new NullReferenceException("index is not in range");
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
        public int Pop(int ind)
        {
            int obj;
            if (ind == 0)
            {
                obj = head.data;
                head = head.next;
                return obj;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }


            if (ind == 0)
            {
                pre.next = t.next;
                obj = t.data;
                return obj;
            }
            throw new NullReferenceException("index is not range");
        }
        public int Size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }
    }
}
