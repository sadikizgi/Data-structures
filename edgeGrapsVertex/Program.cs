using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL07122016
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> gObj = new Graph<int>();
            //for (int i = 1; i < 10; i++)
            //{
            //    gObj.addVertex(i);
            //}

            //int[] sayilar = new int[3];
            //Random rnd = new Random();
            ////Dizi dolduruluyor
            //for (int i = 0; i < 3; i++)
            //{
            //    sayilar[i] = rnd.Next(1, gObj.vertexCount());
            //    for (int kontrol = 0; kontrol < i; kontrol++)
            //    {
            //        if (sayilar[kontrol] == sayilar[i])
            //        {
            //            i--;
            //            break;
            //        }
            //    }
            //}
            //for (int j = 0; j < gObj.vertexCount(); j++)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        gObj.addEdge(j + 1, sayilar[i]);
            //        gObj.addEdge(sayilar[i], j + 1);
            //    }
            //}

            //gObj.addVertex(1);
            //gObj.addVertex(7);
            //gObj.addVertex(12);
            //gObj.addVertex(23);
            //gObj.addVertex(25);
            //gObj.addVertex(45);
            //gObj.addEdge(1, 23);
            //gObj.addEdge(23, 1);
            //gObj.addEdge(12, 23);
            //gObj.addEdge(23, 12);
            //gObj.addEdge(23, 7);
            //gObj.addEdge(7, 23);
            //gObj.addEdge(7, 25);
            //gObj.addEdge(25, 7);
            //gObj.addEdge(25, 45);
            //gObj.addEdge(45, 25);
            //gObj.adjacencyMatrix();
            ////gObj.display();

            //Console.ReadKey();


            Graph<string> g1 = new Graph<string>();
            g1.addVertex("A");
            g1.addVertex("B");
            g1.addVertex("C");
            g1.addVertex("D");
            g1.addVertex("E");
            g1.addEdge("A","B");
            g1.addEdge("A", "C");
            g1.addEdge("A", "D");
            g1.addEdge("A", "E");
            g1.addEdge("B", "D");
            g1.addEdge("C", "D");
            g1.addEdge("C", "E");
            g1.addEdge("D", "E");
            

            g1.TopologicalSorting();
        }
    }
}
