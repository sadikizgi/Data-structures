using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL30112016
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> gObj = new Graph<int>();
            gObj.addVertex(0);
            gObj.addVertex(1);
            gObj.addVertex(2);
            gObj.addVertex(3);
            gObj.addEdge(0, 1);
            gObj.addEdge(0, 2);
            gObj.addEdge(0, 3);
            gObj.addEdge(3, 2);
            gObj.display();
        }
    }
}
