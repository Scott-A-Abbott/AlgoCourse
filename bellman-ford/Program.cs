using System;
using System.Collections.Generic;

namespace BellmanFord
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vertex> vertices = new List<Vertex>();

            vertices.Add(new Vertex("A"));
            vertices.Add(new Vertex("B"));
            vertices.Add(new Vertex("C"));

            List<Edge> edges = new List<Edge>();

            edges.Add(new Edge(1, vertices[0], vertices[1]));
            edges.Add(new Edge(-1, vertices[1], vertices[2]));
            edges.Add(new Edge(-1, vertices[2], vertices[0]));

            BellmanFord bellmanFord = new BellmanFord(edges, vertices);

            bellmanFord.Run(vertices[0]);
            // bellmanFord.ShortestPathTo(vertices[2]);
        }
    }
}
