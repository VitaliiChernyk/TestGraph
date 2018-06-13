using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGraph
{
    class TestGraph
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of vertices -");
            int vertix = Int32.Parse(Console.ReadLine());
            AdjacencyList adjacencyList = new AdjacencyList(vertix);
            Console.WriteLine("Enter number of edges -");
            int edges = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter vedges with weights - ");
            int startVertex, endVertex, weight;
            for (int i = 0; i < edges; i++)
            {
                startVertex = Int32.Parse(Console.ReadLine());
                endVertex = Int32.Parse(Console.ReadLine());
                weight = Int32.Parse(Console.ReadLine());
                adjacencyList.addEdgeAtEnd(startVertex, endVertex, weight);
            }
            adjacencyList.printAdjacencyList();
            adjacencyList.removeEdge(1, 2, 1);
            adjacencyList.printAdjacencyList();
            Console.ReadKey();
        }
    }
}
