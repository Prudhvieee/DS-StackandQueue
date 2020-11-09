using System;

namespace DS_StackandQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures Stack and Queue");
            //UC-1 
            //Creating stack and pushing elements into it
            LinkedListStack stack = new LinkedListStack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();
            //UC-2
            //Peak and pop the elements from the stack
            stack.Size();
            stack.Peak();
            stack.Pop();
            Console.WriteLine("Stack :");
            stack.Display();
            stack.Size();
            //UC-3
            //adding elements to the queue
            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
        }
    }
}
