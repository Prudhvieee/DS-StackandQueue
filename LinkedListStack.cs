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
                Console.WriteLine("Stack is Empty");
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
    }
}
