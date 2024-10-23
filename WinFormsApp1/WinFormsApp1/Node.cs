using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    using System;

    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int value)
        {
            data = value;
            next = null;
            prev = null;
        }
    }

    internal class List
    {
        public Node head;
        public Node tail;
        public int count;

        public List()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddFirst(int value)
        {
            Node newNode = new(value);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            count++;
        }

        public void AddLast(int value)
        {
            Node newNode = new(value);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            count++;
        }

        public void RemoveFirst()
        {
            if (head == null) return; 
            if (head == tail) 
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.prev = null;
            }
            count--;
        }

        public void RemoveLast()
        {
            if (tail == null) return; 
            if (head == tail) 
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
            }
            count--;
        }

        public int GetInt(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Błąd, nie ma podanego node'a.");
                return -1; 
            }

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            return current.data;
        }
    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            List myList = new();

            myList.AddFirst(10);
            myList.AddLast(20);
            myList.AddFirst(5);
            myList.AddLast(25);

            MessageBox.Show("Element dla 2 " + myList.GetInt(2)); 

            myList.RemoveFirst();
            myList.RemoveLast();

            MessageBox.Show("element dla 0 " + myList.GetInt(0));
            MessageBox.Show("Łącznie " + myList.count); 
        }
    }

}
