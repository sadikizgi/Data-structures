using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL23112016
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);
            tree.Add(4);
            tree.Add(7);
            tree.Add(3);
            tree.Add(1);
            tree.Add(2);
            tree.DisplayTree();
        }
    }
}
