using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        //constructor
        public Node(int item)
        {
            data = item;
            next = null;
        }
    }
    public class LinkedListSequence
    { 
        public Node head;
 
        public void Adding(int newValue)
        {
            Node newNode = new Node(newValue);
            newNode.next = head;
            head = newNode;
            Console.WriteLine(newNode.data+" Inserted into the list in front ");
        }

        public void Display()
        {
            Console.WriteLine("\nLinked List Sequence\n");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("\nLinked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if(temp.next != null)
                    {
                        Console.Write(" -> ");
                    }
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}
