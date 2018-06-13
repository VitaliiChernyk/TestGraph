using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGraph
{
    class Edge<T>
    {
        private Vertex<T> node1;
        private Vertex<T> node2;
    }
    class Vertex<T>
    {
        private T data;
        private LinkedList<Edge<T>> neigbors;
    }
}
