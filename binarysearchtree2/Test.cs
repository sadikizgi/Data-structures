using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL02112016
{
    class Test
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(10);
            tree.Add(3);
            tree.Add(2);
            tree.Add(6);
            tree.Add(4);
            tree.Add(12);
            tree.Add(11);
            tree.Add(15);
            tree.InOrder();
            Console.WriteLine();
            tree.Delete(3);
            Console.WriteLine();
            tree.PreOrder();
            tree.Delete(10);
            Console.WriteLine();
            tree.PreOrder();
            tree.Delete(12);
            Console.WriteLine();
            tree.PreOrder();
            tree.Delete(30);
            Console.WriteLine();
            tree.PreOrder();
            tree.Delete(11);
            Console.WriteLine();
            tree.PreOrder();
            
        }
    }
}
