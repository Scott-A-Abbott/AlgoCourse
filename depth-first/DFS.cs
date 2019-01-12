using System;
using System.Collections;
using System.Collections.Generic;

public class DFS
{



    public static void dfs(List<Vertex> vertices)
    {
        foreach (Vertex v in vertices)
        {
            if (!v.Visited)
            {
                v.Visited = true;
                // dfsWithStack(v);
                dfsWithRecursion(v);
            }
        }
    }
    private static void dfsWithRecursion(Vertex root)
    {
        Console.WriteLine(root.Name);

        foreach (Vertex neighbor in root.NeighborList)
        {
            if (!neighbor.Visited)
            {
                neighbor.Visited = true;
                dfsWithRecursion(neighbor);
            }
        }
    }
    private static void dfsWithStack(Vertex root)
    {
        Stack<Vertex> stack = new Stack<Vertex>();

        stack.Push(root);
        root.Visited = true;

        while (stack.ToArray().Length > 0)
        {
            Vertex actualVertex = stack.Pop();
            Console.WriteLine(actualVertex.Name);

            foreach (Vertex v in actualVertex.NeighborList)
            {
                if (!v.Visited)
                {
                    v.Visited = true;
                    stack.Push(v);
                }
            }
        }
    }
}