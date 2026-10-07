using System;
using DSA.LinkedList;

namespace DSA.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();

            list.Append(5);
            list.Append(10);
            list.Append(15);

            list.Display();
        }
    }
}
