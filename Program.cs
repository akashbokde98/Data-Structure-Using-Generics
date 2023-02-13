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
            listobj.Search(30);
            listobj.Insert(2, 40);
        }
    }
}
