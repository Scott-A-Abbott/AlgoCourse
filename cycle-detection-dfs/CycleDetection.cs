using System;
using System.Collections;
using System.Collections.Generic;

namespace CycleDetection
{
    public class CycleDetection
    {
        public void detectCycle(List<Vertex> list)
        {
            foreach (Vertex v in list)
            {
                if (!v.IsVisited)
                {
                    dfs(v);
                }
            }
        }
        private void dfs(Vertex vertex)
        {
            Console.WriteLine("DFS on Vertex: " + vertex.Name);
            vertex.BeingVisited = true;
            foreach (Vertex v in vertex.AdjacentVertecies)
            {
                Console.WriteLine("Visiting the neighbors of vertex: " + vertex.Name);
                if (v.BeingVisited)
                {
                    Console.WriteLine("This is a backwards edge, so there is a cycle!");
                    return;
                }
                if (!v.IsVisited)
                {
                    Console.WriteLine($"Visiting the vertex {v} recursively...");
                    dfs(v);
                }
            }
            Console.WriteLine($"Set vertex {vertex} BeingVisited to false and Visited to true");
            vertex.BeingVisited = false;
            vertex.IsVisited = true;
        }
    }
}