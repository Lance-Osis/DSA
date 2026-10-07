using System;

namespace DSA.LinkedList
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int Value)
        {
            this.Data = Value;
            this.Next = null;
        }
    }

    public class DoubleLinkedList
    {
        public Node Head;

        public void Append(int Value)
        {
            Node NewNode = new Node(Value);

            if (Head == null)
            {
                Head = NewNode;
                return;
            }

            Node Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }

            Current.Next = NewNode;
        }

        public void Display()
        {
            Node Pointer = Head;

            while (Pointer != null)
            {
                Console.Write($"{Pointer.Data} -> ");
                Pointer = Pointer.Next;
            }

            Console.WriteLine("Null");
        }
    }
}