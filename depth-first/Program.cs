using System;
using System.Collections.Generic;
using static DFS;
    class Program
    {
        static void Main(string[] args)
        {
            Vertex v1 = new Vertex("1");
            Vertex v2 = new Vertex("2");
            Vertex v3 = new Vertex("3");
            Vertex v4 = new Vertex("4");
            Vertex v5 = new Vertex("5");

            List<Vertex> list = new List<Vertex>();
            
            v1.addNeighborVertex(v2);
            v1.addNeighborVertex(v3);
            v3.addNeighborVertex(v4);
            v4.addNeighborVertex(v5);

            list.Add(v1);

            dfs(list);
        }
    }