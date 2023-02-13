using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;

        public Node(T value)
        {
            data = value;
            next = null;
        }
    }
    internal class SortList<T>where T : IComparable<T>
    {
        private Node<T> head = null;
        public Node<T> tail = null;
        public bool AddNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                return true;
            }
            tail.next = newNode;  
            tail = newNode;
            return true;
        }
        public void sortList()
        {
            Node<T> current = head;
            Node<T> index = null;
            T temp;

            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                { 
                    index = current.next;

                    while (index != null)
                    { 
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        public void display()
        {  
            Node<T> current = head;
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            while (current != null)
            {  
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
