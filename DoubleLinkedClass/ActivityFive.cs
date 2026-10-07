using System;

namespace DSA.ActFive
{
    // Step 1: Define the Node class with data, pointers (next and prev), and a constructor to initialize them.
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int Value)
        {
            this.data = Value;
            this.next = null;
            this.prev = null;
        }
    }

    // Step 2: Define the DoubleLinkedList class with methods to append, prepend, and display nodes.
    public class DoubleLinkedList
    {
        public Node Head;
        public Node Tail;

        public void Append(int Value)
        {
            Node NewNode = new Node(Value);

            // If the list is empty
            if (Head == null)
            {
                Head = NewNode;
                Tail = NewNode;
                return;
            }

            // Attach new node to the end of the list
            Tail.next = NewNode;
            NewNode.prev = Tail;
            
            // Move Tail pointer to the new end
            Tail = NewNode;
        }

        // Step 3: Setting up the Display method with the pointer
        public void Display()
        {
            // forward 
            Node current = Head;
            Console.Write("Forward:  ");
            while (current != null)
            {
                Console.Write($"{current.data} -> ");
                current = current.next;
            }
            Console.WriteLine("null");

            // backward
            current = Tail;
            Console.Write("Backward: ");
            while (current != null)
            {
                Console.Write($"{current.data} -> ");
                current = current.prev;
            }
            Console.WriteLine("null");
        }
    }
}
