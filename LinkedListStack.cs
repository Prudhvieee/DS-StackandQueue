using System;
using System.Collections.Generic;
using System.Text;

namespace DS_StackandQueue
{
    public class LinkedListStack
    {
        Node top;
        /// <summary>
        /// Pushes the specified data into the stack.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                top = node;
            }
            else
            {
                node.next = top;
                top = node;
            }
            Console.WriteLine(node.data + " pushed to Stack");
        }
        /// <summary>
        /// Displays the elements present in the stack.
        /// </summary>
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack is Empty\n");
            }
            else
            {
                Node node = top;
                while (node.next != null)
                {
                    Console.Write(node.data + " ");
                    node = node.next;
                }
                Console.Write(node.data + "\n");
            }
        }
        /// <summary>
        /// Pop the element from the stack.
        /// </summary>
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack is Empty\n");
            }
            else
            {
                Console.WriteLine(top.data + " popped from the Stack");
                top = top.next;
            }
        }
        /// <summary>
        /// Peaks the top element from the stack.
        /// </summary>
        public void Peak()
        {
            if (top == null)
            {
                Console.WriteLine("\nStack is Empty\n");
            }
            else
            {
                Console.WriteLine(top.data + " is the peak element top of Stack");
            }
        }
        // <summary>
        /// Gives the size of stack.
        /// </summary>
        public void Size()
        {
            int count = 0;
            Node temp = top;
            if (temp == null)
            {
                Console.WriteLine("\nStack is Empty\n");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("\nSize :" + count);
        }
        /// <summary>
        /// makes the stack empty
        /// </summary>
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peak();
                Pop();
                Console.WriteLine("\nStack is Empty\n");
            }
        }
    }
}
