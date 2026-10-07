using System;

namespace DSA.StackArray
{
    // Step 1: Define the myStack class with an array, top pointer, and capacity.
    public class myStack {
        private int[] arr;
        private int top;
        private int capacity;

        public myStack(int n) {
            capacity = n;
            arr = new int[capacity];
            top = -1; // -1 indicates the stack is initially empty
        }

        public bool isEmpty() {
            return top == -1;
        }

        public bool isFull() {
            return top == capacity - 1;
        }

        public void push(int x) {
            if (isFull()) {
                Console.WriteLine($"Stack Overflow: Cannot push {x}. Stack is full.");
                return;
            }
            arr[++top] = x;
            Console.WriteLine($"Pushed {x} onto the stack.");
        }

        public void pop() {
            if (isEmpty()) {
                Console.WriteLine("Stack Underflow: Cannot pop from an empty stack.");
                return;
            }
            Console.WriteLine($"Popped {arr[top]} from the stack.");
            top--;
        }

        public int peek() {
            if (isEmpty()) {
                Console.WriteLine("Stack is empty. No top element.");
                return -1;
            }
            return arr[top];
        }
    }
}
class myStack {
    private int[] arr;
    private int top;
    private int capacity;

    public myStack(int n) {
        capacity = n;
        arr = new int[capacity];
        top = -1; // -1 indicates the stack is initially empty
    }

    public bool isEmpty() {
        return top == -1;
    }

    public bool isFull() {
        return top == capacity - 1;
    }

    public void push(int x) {
        if (isFull()) {
            Console.WriteLine($"Stack Overflow: Cannot push {x}. Stack is full.");
            return;
        }
        arr[++top] = x;
        Console.WriteLine($"Pushed {x} onto the stack.");
    }

    public void pop() {
        if (isEmpty()) {
            Console.WriteLine("Stack Underflow: Cannot pop from an empty stack.");
            return;
        }
        Console.WriteLine($"Popped {arr[top]} from the stack.");
        top--;
    }

    public int peek() {
        if (isEmpty()) {
            Console.WriteLine("Stack is empty. No top element.");
            return -1;
        }
        return arr[top];
    }
}