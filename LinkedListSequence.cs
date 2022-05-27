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
        public void Appending(int newValue1)
        {
            Node newNode1 = new Node(newValue1);
            if (head == null)
            {
                head = newNode1;
            }
            else
            {
                Node lastNode = Last();
                lastNode.next = newNode1;
            }
            Console.WriteLine(newNode1.data + " Inserted into the list in last ");
        }
        public Node Last()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        public void InsertInBetween(int pos, int newValue)
        {
            Node newNode = new Node(newValue);
            if (pos == 1)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (pos <= 0)
            {
                Console.WriteLine("position not correct");
            }
            else if (pos > 1)
            {
                Node temp = head;
                while (pos != 1)
                {
                    if (pos == 2)
                    {
                        Console.WriteLine("\n"+newNode.data+" is inserted between two nodes");
                        newNode.next = temp.next;
                        temp.next = newNode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(pos);
                    pos--;
                }
            }
        }
        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            
            Console.WriteLine("\n"+head.data + " is deleted from the list");
            head = head.next;
        }
        public void PopLast()
        {
            Node newNode = head;

            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            if (head.next == null)
            {
                head = null;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Console.WriteLine("\n" + newNode.next.data + " is deleted from the list");
            newNode.next = null;
        }
        public void Search(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\n"+value+" is present in the linked list" );
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("\n"+value + " is not present in the linked list");
        }
        public void SearchAndInsert(int value, int data)
        {
            Node temp = head;
            Node newNode = new Node(data);
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("\n" + value + " is present in the linked list");
                    newNode.next = temp.next;
                    temp.next = newNode;
                    Console.WriteLine("\n" + newNode.data + " is inserted next to "+value +" in the linked list");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("\n" + value + " is not present in the linked list");
        }
        public void SearchAndDelete(int value)
        {
            Node temp = head;
            while (temp.next != null)
            {
                if (temp.next.data == value)
                {
                    temp.next = temp.next.next;
                    Console.WriteLine("\n" + value + " is deleted from the linked list");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("\n" + value + " is not present in the linked list");
        }
        public void Size()
        {
            int value = 0;
            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
                value++;
            }
            Console.WriteLine("\nSize of linked list : "+value);
        }
        public void Display()
        {
            Console.Write("\nLinked List Sequence\t");
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
