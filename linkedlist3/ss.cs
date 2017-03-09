using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_linkedlist_12102016
{
    class ss<T> where T:IComparable
    {
        public Node<T> head = null;
        public void fun1 ()
        {
            Node<T> iterator = head;
            Node<T> Temp = iterator.Next;
            iterator.Next = Temp;
            head = head.Next;
        }
        public void fun2 (T x)
        {
            head = fun6(head, x);
        }
        public Node<T> fun6 (Node<T> n , T x)
        {
            if (n == null)
            {
                return new Node<T>(x);
            }
            else
            {
                n.Next = fun6(n.Next, x);

            }
            return n;
        }
        public void fun3 (T x)
        {
            Node<T> temp = new Node<T>(x);
            temp.Next = head;
            head = temp;
        }
        public void fun4 ()
        {
            Node<T> iterator = head; 
            while (iterator != null)
            {
                Console.WriteLine(iterator.Value);
                iterator = iterator.Next;
            }


        }

        public void fun5 ()
        {
            Node<T> iterator = head;
            while (head.Next != null)
            {
                head = head.Next;
            }
        }




    }
}
