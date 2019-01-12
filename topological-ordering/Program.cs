using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        TO to = new TO();
        List<Vertex> graph = new List<Vertex>();

        graph.Add(new Vertex("a"));
        graph.Add(new Vertex("b"));
        graph.Add(new Vertex("c"));
        graph.Add(new Vertex("d"));
        graph.Add(new Vertex("e"));
        graph.Add(new Vertex("f"));

        graph[2].addNeighbor(graph[3]);
        graph[3].addNeighbor(graph[1]);
        graph[4].addNeighbor(graph[0]);
        graph[5].addNeighbor(graph[1]);
        graph[5].addNeighbor(graph[0]);
        graph[5].addNeighbor(graph[2]);

        foreach (Vertex v in graph)
        {
            if(!v.IsVisited)
            {
                to.dfs(v);
            }
        }

        Stack<Vertex> stack = to.Stack;

        foreach (Vertex v in stack)
        {
            Console.Write($"{v.Data} -> ");
        }
    }
}
