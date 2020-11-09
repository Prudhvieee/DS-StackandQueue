using System;

namespace DS_StackandQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures Stack and Queue");
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            stack.Size();
            stack.Peak();
            stack.Pop();
            Console.WriteLine("Stack :");
            stack.Display();
            stack.Size();
        }
    }
}
