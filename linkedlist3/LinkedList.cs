using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_linkedlist_12102016
{
    class LinkedList<T> where T : IComparable
    {
        Node<T> head;

        public void AddToFront(T val)
        {
            Node<T> newNode = new Node<T>(val);
            newNode.Next = head;
            head = newNode;
        }

        public void AddToEnd(T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> iterator = head;
            if (head == null)
                head = newNode;
            else
            {
                while(iterator.Next != null)
                {
                    iterator = iterator.Next;
                }
                iterator.Next = newNode;
            }
        }

        public void DeleteLast()
        {
            Node<T> iterator = head;
            Node<T> prev = head;

            if (head == null || head.Next == null)
                head = null;
            else
            {
                while(iterator.Next != null)
                {
                    prev = iterator;
                    iterator = iterator.Next;
                }
                prev.Next = null;
            }
        }

        public void Display()
        {
            Node<T> iterator = head;
            while(iterator != null)
            {
                Console.Write(iterator.Value + " ");
                iterator = iterator.Next;
            }
            Console.WriteLine();
        }

        public void Search(T val)
        {
            int flag = 0;
            Node<T> iterator = head;
            if (head == null)
                Console.WriteLine("The linked list is empty!!!");
            else
            {
                while(iterator != null)
                {
                    if (iterator.Value.CompareTo(val) == 0)
                    {
                        flag++;
                        break;
                    }
                    else
                        iterator = iterator.Next;
                }
                if(flag != 0)
                    Console.WriteLine("The linked list includes {0}",val);
                else
                    Console.WriteLine("The linked list doesn't include {0}", val);
            }
        }

        public void AddToOrderedList(T val)
        {
            Node<T> newNode = new Node<T>(val);
            Node<T> iterator = head;
            if (head == null)
                head = newNode;
            else
            {
                if(head.Value.CompareTo(val) > 0)
                {
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    while (iterator.Next != null && iterator.Next.Value.CompareTo(val) <= 0)
                    {
                        iterator = iterator.Next;
                    }
                    newNode.Next = iterator.Next;
                    iterator.Next = newNode;
                }    
            }
        }

    }
}
