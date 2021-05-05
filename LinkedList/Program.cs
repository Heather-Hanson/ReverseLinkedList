using System;
using System.Collections.Generic;


namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNode(new LinkedList.Node("R"));
            list.AddNode(new LinkedList.Node("E"));
            list.AddNode(new LinkedList.Node("H"));
            list.AddNode(new LinkedList.Node("T"));
            list.AddNode(new LinkedList.Node("A"));
            list.AddNode(new LinkedList.Node("E"));
            list.AddNode(new LinkedList.Node("H"));



            Console.WriteLine("Here's the starting list: ");
            list.PrintList();

            list.ReverseList();

            Console.WriteLine("Here it is in reverse: ");
            list.PrintList();

            Console.ReadLine();
        }
    }
    class LinkedList
    {
        Node head;

        public class Node
        {
            public string data;
            public Node next;

            public Node(string d)
            {
                data = d;
                next = null;
            }
        }
        public void AddNode(Node node)
        {
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void ReverseList()
        {
            Node prev = null, current = head, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }
        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data + ' ');
                current = current.next;
            }
            Console.WriteLine();
        }
        

    }
}
