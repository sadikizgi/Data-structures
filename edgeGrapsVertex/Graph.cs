using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL07122016
{
    class Graph<T> where T : IComparable
    {
        Vertex<T> vertexHead;
        private Vertex<T> createVertex(T val)
        {
            return new Vertex<T>(val);
        }
        private Edge<T> createEdge(T val)
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
                {
                    iterator = iterator.NextVertex;
                }
                iterator.NextVertex = createVertex(val);
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
        public void addEdge(T vertexVal, T edgeVal)
        {
            if (vertexHead == null)
            {
                Console.WriteLine("Önce vertex eklemelisiniz.");
            }
            else
            {
                Vertex<T> iterator = search(vertexVal);
                if (iterator != null && search(edgeVal)!=null)
                {
                    if (iterator.NextEdge == null)
                        iterator.NextEdge = createEdge(edgeVal);
                    else
                    {
                        Edge<T> iteratorEdge = iterator.NextEdge;
                        while (iteratorEdge.NextEdge != null)
                        {
                            iteratorEdge = iteratorEdge.NextEdge;
                        }
                        iteratorEdge.NextEdge = createEdge(edgeVal);
                    }
                }
                else
                    Console.WriteLine("Vertex bulunamadı...");
            }
        }

        public void display()
        {
            Vertex<T> iterator = vertexHead;
            while (iterator != null)
            {
                Console.Write(iterator.ToString() + " --> ");
                Edge<T> iteratorEdge = iterator.NextEdge;
                while (iteratorEdge != null)
                {
                    Console.Write(iteratorEdge.ToString() + " ");
                    iteratorEdge = iteratorEdge.NextEdge;
                }
                Console.WriteLine();
                iterator = iterator.NextVertex;
            }
            Console.WriteLine();
        }

        public int vertexCount()
        {
            Vertex<T> iterator = vertexHead;
            int count = 0;
            while (iterator != null)
            {
                count++;
                iterator = iterator.NextVertex;
            }
            return count;
        }

        public int isAdjacency(T vertex, T edge)
        {
            Vertex<T> iterator = search(vertex);
            if (iterator != null)
            {
                Edge<T> iteratorE = iterator.NextEdge;
                while (iteratorE != null)
                {
                    if (iteratorE.EdgeValue.CompareTo(edge) == 0)
                        return 1;
                    iteratorE = iteratorE.NextEdge;
                }
            }
            return 0;
        }

        public void adjacencyMatrix()
        {
            int n = vertexCount();
            int[,] matrix = new int[n + 1, n + 1];
            T[] vertex = new T[n];
            Vertex<T> iterator = vertexHead;
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                matrix[0, i] = Convert.ToInt32(iterator.VertexValue.ToString());
                matrix[i, 0] = Convert.ToInt32(iterator.VertexValue.ToString());
                vertex[i - 1] = iterator.VertexValue;
                iterator = iterator.NextVertex;
            }
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    matrix[i, j] = isAdjacency(vertex[i - 1], vertex[j - 1]);
                }
            }
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    Console.Write("{0} \t", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void visited(T val)
        {
            Vertex<T> iterator = vertexHead;
            Edge<T> iteratorE = null;
            while (iterator != null)
            {
                if (iterator.VertexValue.CompareTo(val) == 0)
                    iterator.Visited = true;
                iteratorE = iterator.NextEdge;
                while (iteratorE != null)
                {
                    if (iteratorE.EdgeValue.CompareTo(val) == 0)
                    {
                        iteratorE.Visited = true;
                    }
                    iteratorE = iteratorE.NextEdge;
                }
                iterator = iterator.NextVertex;
            }
        }

        public Graph<T> copyGraph()
        {
            Graph<T> newGraph = new Graph<T>();
            Vertex<T> vertexIterator = vertexHead;
            Edge<T> edgeIterator;

            while (vertexIterator != null)
            {
                newGraph.addVertex(vertexIterator.VertexValue);
                vertexIterator = vertexIterator.NextVertex;
            }

            vertexIterator = vertexHead;

            while (vertexIterator != null)
            {
                edgeIterator = vertexIterator.NextEdge;
                while (edgeIterator != null)
                {
                    newGraph.addEdge(vertexIterator.VertexValue, edgeIterator.EdgeValue);
                    edgeIterator = edgeIterator.NextEdge;
                }
                vertexIterator = vertexIterator.NextVertex;
            }
            return newGraph;

        }

        public void deleteVertex(T val)
        {
            if (search(val) == null)
                return;

            Vertex<T> vertexIterator = vertexHead;
            Edge<T> edgeIterator,prevEdge;

            while (vertexIterator != null) //gelen edgeleri siler
            {

                edgeIterator = vertexIterator.NextEdge;
                prevEdge = edgeIterator;
                if (edgeIterator!=null && vertexIterator.NextEdge.EdgeValue.CompareTo(val) == 0)//edge head olma durumu
                    vertexIterator.NextEdge = edgeIterator.NextEdge;
                while (edgeIterator != null)//edge headde degilse
                {
                    if (edgeIterator.EdgeValue.CompareTo(val) == 0)
                        prevEdge.NextEdge = edgeIterator.NextEdge;

                    prevEdge = edgeIterator;
                    edgeIterator = edgeIterator.NextEdge;
                }
                vertexIterator = vertexIterator.NextVertex;
            }

            //vertexi silme
            if (vertexHead.VertexValue.CompareTo(val) == 0)
                vertexHead = vertexHead.NextVertex;
            else
            {
                vertexIterator = vertexHead;
                while (vertexIterator.NextVertex.VertexValue.CompareTo(val) != 0)//while sonrası iterator previousu gosterir
                    vertexIterator = vertexIterator.NextVertex;
                vertexIterator.NextVertex = vertexIterator.NextVertex.NextVertex;

            }


        }


        public int indegree(T val)
        {
            if (search(val) == null)
                return -1;

            Vertex<T> vertexIterator = vertexHead;
            Edge<T> edgeIterator;
            int count = 0;

            while (vertexIterator != null)
            {
                edgeIterator = vertexIterator.NextEdge;
                while (edgeIterator != null)
                {
                    if (edgeIterator.EdgeValue.CompareTo(val) == 0)
                        count++;
                    edgeIterator = edgeIterator.NextEdge;
                }
                vertexIterator = vertexIterator.NextVertex;
            }
            return count;
        }

        public Vertex<T> findZeroIndegree()
        {
            Vertex<T> vertexIterator = vertexHead;

            while (vertexIterator != null)
            {
                if (indegree(vertexIterator.VertexValue) == 0)
                    return vertexIterator;

                vertexIterator = vertexIterator.NextVertex;
            }
            return null;

        }

        public void TopologicalSorting()
        {
            Vertex<T> temp;

            Graph<T> g = copyGraph();
            while (g.vertexHead != null)
            {
                temp = g.findZeroIndegree();
                if (temp == null)
                {
                    Console.WriteLine("Graph DAG degil");
                    return;
                }
                Console.WriteLine(temp.VertexValue);
                g.deleteVertex(temp.VertexValue);
            }


        }


    }
}
