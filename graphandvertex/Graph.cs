using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL30112016
{
    class Graph<T> where T : IComparable
    {
        Vertex<T> vertexHead;
        public Vertex<T> createVertex(T val)
        {
            return new Vertex<T>(val);
        }
        public Edge<T> createEdge(T val)
        {
            return new Edge<T>(val);
        }
        public void addVertex(T val)
        {
            if (vertexHead == null)
            {
                vertexHead = createVertex(val);
            }
            else
            {
                Vertex<T> iterator = vertexHead;
                while (iterator.NextVertex != null)
                    iterator = iterator.NextVertex;
                iterator.NextVertex = createVertex(val);
            }
        }
        public void addEdge(T vertexValue, T edgeValue)
        {
            if (vertexHead == null)
                Console.WriteLine("Vertex yok...");
            else
            {
                Vertex<T> iterator = search(vertexValue);
                if (iterator != null)
                {
                    if (iterator.NextEdge == null)
                        iterator.NextEdge = createEdge(edgeValue);
                    else
                    {
                        Edge<T> iteratorEdge = iterator.NextEdge;
                        while (iteratorEdge.NextEdge != null)
                        {
                            iteratorEdge = iteratorEdge.NextEdge;
                        }
                        iteratorEdge.NextEdge = createEdge(edgeValue);
                    }
                }
                else
                    Console.WriteLine("Aranan vertex bulunamadi...");
            }
        }
        public Vertex<T> search(T val)
        {
            Vertex<T> iterator = vertexHead;
            while (iterator != null && iterator.VertexValue.CompareTo(val) != 0)
            {
                iterator = iterator.NextVertex;
            }
            return iterator;
        }
        public void display()
        {
            Vertex<T> iteratorV = vertexHead;
            Edge<T> iteratorE = null;
            while (iteratorV != null)
            {
                iteratorE = iteratorV.NextEdge;
                Console.Write(iteratorV.VertexValue + "-->");
                while (iteratorE != null)
                {
                    Console.Write(iteratorE.EdgeValue + "--");
                    iteratorE = iteratorE.NextEdge;
                }
                Console.WriteLine();
                iteratorV = iteratorV.NextVertex;
            }
        }
    }
}
