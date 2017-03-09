using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYL30112016
{
    class Edge<T>
    {
        T edgeValue;
        Edge<T> nextEdge;
        public T EdgeValue
        {
            get { return edgeValue; }
            set { edgeValue = value; }
        }
        public Edge<T> NextEdge
        {
            get { return nextEdge; }
            set { nextEdge = value; }
        }
        public Edge(T val)
        {
            edgeValue = val;
            nextEdge = null;
        }
    }
}
