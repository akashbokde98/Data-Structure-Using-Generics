using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List listobj = new List();

            listobj.Add(70);
            listobj.Add(30);
            listobj.Add(56);
            listobj.Insert(2, 40);
            listobj.Search(40);
            listobj.Pop(2);
            Console.WriteLine("Linked List Size is-" + listobj.Size());
        }
    }
}
