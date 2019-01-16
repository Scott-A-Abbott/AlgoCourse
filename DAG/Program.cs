using System;
using System.Collections.Generic;

namespace DAG
{
    class Program
    {
        static void Main(string[] args)
        {
            Vertex vertex0 = new Vertex("A");
            Vertex vertex1 = new Vertex("B");
            Vertex vertex2 = new Vertex("C");

            List<Vertex> vertexList = new List<Vertex>();
            vertexList.Add(vertex0);
            vertexList.Add(vertex1);
            vertexList.Add(vertex2);

            vertex0.addNeighbor(new Edge(1, vertex0, vertex1));
            vertex0.addNeighbor(new Edge(10, vertex0, vertex2));
            vertex1.addNeighbor(new Edge(1, vertex1, vertex2));

            AcyclicShortestPath acyclic = new AcyclicShortestPath();
            acyclic.ShortestPath(vertexList, vertex0, vertex2);
            acyclic.showShortestPathTo(vertex2);
        }
    }
}
