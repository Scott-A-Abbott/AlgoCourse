using System;
using System.Collections.Generic;
using static Dijkstra.Dijkstra;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex vertex0 = new Vertex("A");
            Vertex vertex1 = new Vertex("B");
            Vertex vertex2 = new Vertex("C");

            vertex0.addNeighbor( new Edge(1, vertex0, vertex1));
            vertex0.addNeighbor( new Edge(3, vertex0, vertex2));
            vertex1.addNeighbor( new Edge(1, vertex1, vertex2));

            computePaths(vertex0);

            List<Vertex> sp = GetShortestPathTo(vertex2);

            foreach(Vertex v in sp){
                Console.Write($"{v.Name} => ");
            }
        }
    }
}
