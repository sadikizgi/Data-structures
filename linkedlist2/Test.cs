using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VY11102016
{
    class Test
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddToFront(5);
            list.AddToFront(3);
            list.AddToFront(1);
            list.AddToEnd(9);
            list.Display();

        }
    }
}
