using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _14253607HW2
{
    class LinkedList<T> where T : IComparable
    {
        public Node<T> head;
        public void AddtoEnd (T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> iterator = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while(iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = newNode;
            }
        }

        public void AddToFront(T val)
        {
            Node<T> newNode = new Node<T>(val);
            newNode.Next = head;
            head = newNode;
        }

        public void Display()
        {
            Node<T> iterator = head;
            while (iterator != null)
            {
                Console.Write(iterator.Value + " ");
                iterator = iterator.Next;
            }
            Console.WriteLine();
        }
    }
}
