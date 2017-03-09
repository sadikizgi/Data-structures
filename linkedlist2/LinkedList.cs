using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY11102016
{
    class LinkedList<T> where T :IComparable
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
                while (iterator.Next != null)
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
            if(head==null || head.Next==null)
                head= null;

            while (iterator.Next!=null)
            {
                prev = iterator;
                iterator = iterator.Next;
            }
            prev.Next = null;
            

        }

        public void Display()
        {
            Node<T> iterator = head;
            while(iterator!= null)
            {
                Console.Write(iterator.Value+"  ");
                iterator = iterator.Next;
            }
            //if (head == null)
            //    return;
            //Node<T> iterator = head;
            
            //while (iterator.Next!= null)
            //{
            //    Console.Write(iterator.Value);
            //    iterator = iterator.Next;
                
            //}
            //Console.WriteLine(iterator.Value);


        }
    }
}
