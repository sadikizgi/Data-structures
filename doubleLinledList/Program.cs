using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week5_doubleLinledList_19102016;

namespace week5_doubleLinkedList_19102016
{
    class Program
    {
        static void Main(string[] args)
        {
            DLinkedList<int> list = new DLinkedList<int>();
            list.AddToFront(5);
            list.AddToFront(3);
            list.AddToFront(1);
            list.AddToEnd(9);
            if (list.Search(5))
                Console.WriteLine("This linked list includes 5");
            else
                Console.WriteLine("This linked list does not include 5");
            if (list.Search(13))
                Console.WriteLine("This linked list includes 13");
            else
                Console.WriteLine("This linked list does not include 13");
            list.Display();

            DLinkedList<int> list2 = new DLinkedList<int>();
            list2.AddToOrderedList(400);
            list2.AddToOrderedList(40);
            list2.AddToOrderedList(4);
            list2.AddToOrderedList(450);
            list2.AddToOrderedList(50);
            //list2.Delete(50);
            list2.Delete(450);
            list2.Display();
			list2.DisplayReverse();
        }
    }
}
