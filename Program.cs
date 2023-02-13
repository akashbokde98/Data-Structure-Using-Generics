using System;
using System.Collections.Generic;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
           SortList<int> listObj = new SortList<int>();

            listObj.AddNode(70);
            listObj.AddNode(40);
            listObj.AddNode(30);
            listObj.AddNode(56);

            listObj.sortList();
            listObj.display();

        }
    }
}
