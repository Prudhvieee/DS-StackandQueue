﻿using System;
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
        /// <summary>
        /// Removing elementts from the queue
        /// </summary>
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine(head.data + " removed from Queue");
                head = head.next;
            }
        }
        /// <summary>
        /// Displays the size of the queue
        /// </summary>
        public void Size()
        {
            int count = 0;
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size :" + count);
        }
    }
}
