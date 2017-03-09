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
            Console.WriteLine("node count:"+tree.NodeCount());
            Console.WriteLine(tree.findParent(4).Value);
        }
    }
}
