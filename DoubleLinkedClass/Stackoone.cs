using System;

/// <summary>
/// Generic stack backed by a singly linked list.
/// The head of the list is the top of the stack, so every operation is O(1).
/// </summary>
public class Stackoone<T>
{
    private class Node
    {
        public T Data;
        public Node Next;

        public Node(T data, Node next)
        {
            Data = data;
            Next = next;
        }
    }

    private Node _top;
    private int _count;

    /// <summary>Number of elements in the stack. O(1)</summary>
    public int Count => _count;

    /// <summary>True if the stack has no elements. O(1)</summary>
    public bool IsEmpty() => _top == null;

    /// <summary>Adds an item to the top. O(1)</summary>
    public void Push(T item)
    {
        _top = new Node(item, _top);
        _count++;
    }

    /// <summary>Removes and returns the top item. O(1)</summary>
    public T Pop()
    {
        if (_top == null)
            throw new InvalidOperationException("Stack underflow: the stack is empty.");

        T value = _top.Data;
        _top = _top.Next;
        _count--;
        return value;
    }

    /// <summary>Returns the top item without removing it. O(1)</summary>
    public T Peek()
    {
        if (_top == null)
            throw new InvalidOperationException("The stack is empty.");

        return _top.Data;
    }

    /// <summary>Removes all items. O(1) - the GC reclaims the detached nodes.</summary>
    public void Clear()
    {
        _top = null;
        _count = 0;
    }

    /// <summary>Prints the stack from top to bottom. O(n) - for debugging only.</summary>
    public void Display()
    {
        if (_top == null)
        {
            Console.WriteLine("Stack is empty.");
            return;
        }

        Console.Write("Top -> ");
        for (Node current = _top; current != null; current = current.Next)
            Console.Write(current.Data + (current.Next != null ? " -> " : ""));
        Console.WriteLine(" <- Bottom");
    }
}