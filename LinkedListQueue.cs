using System;
using System.Collections.Generic;
using System.Text;

namespace DS_StackandQueue
{
    public class LinkedListQueue
    {
        Node head;
        /// <summary>
        /// UC-3
        /// Adds the element to the queue.
        /// </summary>
        /// <param name="data">The data.</param>
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
            Console.WriteLine(node.data + " inserted into Queue");
        }
        /// <summary>
        /// Displays all the element from queue.
        /// </summary>
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node node = head;
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
