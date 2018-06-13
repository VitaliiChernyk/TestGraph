using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGraph
{
    public class AdjacencyList
    {
        LinkedList<Tuple<int, int>>[] adjacencyList;
        public AdjacencyList(int vertices)
        {
            adjacencyList = new LinkedList<Tuple<int, int>>[vertices];
            for (int i = 0; i < adjacencyList.Length; i++)
            {
                adjacencyList[i] = new LinkedList<Tuple<int, int>>();
            }
        }
        public void addEdgeAtEnd(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddLast(new Tuple<int, int>(endVertex, weight));
        }
        public void addEdgeAtBegin(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddFirst(new Tuple<int, int>(endVertex, weight));
        }
        public int getNumberOfVertices()
        {
            return adjacencyList.Length;
        }
        public LinkedList<Tuple<int, int>> this[int index]
        {
            get
            {
                LinkedList<Tuple<int, int>> edgeList = new LinkedList<Tuple<int, int>>(adjacencyList[index]);
                return edgeList;
            }
        }
        public void printAdjacencyList()
        {
            int i = 0;
            foreach (LinkedList<Tuple<int, int>> list in adjacencyList)
            {
                Console.WriteLine("adjacencyList[" + i + "]->");
                foreach (Tuple<int, int> edge in list)
                {
                    Console.WriteLine(edge.Item1 + "(" + edge.Item2 + ")");
                }
                ++i;
                Console.WriteLine();
            }
        }
        public bool removeEdge(int startVertex, int endVertex, int weight)
        {
            Tuple<int, int> edge = new Tuple<int, int>(endVertex, weight);
            return adjacencyList[startVertex].Remove(edge);
        }
    }
}
