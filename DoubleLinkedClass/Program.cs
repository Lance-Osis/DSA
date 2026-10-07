using DSA.ActFive;
using DSA.StackArray;

public class Program
{
    static void Main()
    {
        var stack = new Stackoone<int>();
 
        Console.WriteLine($"Is empty? {stack.IsEmpty()}");
 
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Display();                       // Top -> 30 -> 20 -> 10 <- Bottom
 
        Console.WriteLine($"Peek: {stack.Peek()}");   // 30
        Console.WriteLine($"Pop: {stack.Pop()}");     // 30
        Console.WriteLine($"Count: {stack.Count}");   // 2
        stack.Display();
 
        stack.Clear();
        Console.WriteLine($"After Clear, empty? {stack.IsEmpty()}");
 
        try
        {
            stack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
    }
}