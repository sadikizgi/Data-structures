using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL30112016
{
    class Vertex<T>
    {
        T vertexValue;
        Vertex<T> nextVertex;
        Edge<T> nextEdge;

        public T VertexValue
        {
            get { return vertexValue; }
            set { vertexValue = value; }
        }

        public Vertex<T> NextVertex
        {
            get { return nextVertex; }
            set { nextVertex = value; }
        }

        public Edge<T> NextEdge
        {
            get { return nextEdge; }
            set { nextEdge = value; }
        }

        public Vertex(T val)
        {
            vertexValue = val;
            nextEdge = null;
            nextVertex = null;
        }
    }
}
