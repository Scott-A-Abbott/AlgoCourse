using System;
using System.Collections;
using System.Collections.Generic;

public class DFS{

    public static void dfs(List<Vertex> vertices){
        foreach (Vertex v in vertices)
        {
            if(!v.Visited)
            {
                v.Visited = true;
                dfsWithStack(v);
            }
        }
    }

    private static void dfsWithStack(Vertex root)
    {
        Stack<Vertex> stack = new Stack<Vertex>();

        stack.Push(root);
        root.Visited = true;

        while(stack.ToArray().Length > 0)
        {
            Vertex actualVertex = stack.Pop();
            Console.WriteLine(actualVertex.Name);

            foreach (Vertex v in actualVertex.NeighborList)
            {
                if(!v.Visited)
                {
                    v.Visited = true;
                    stack.Push(v);
                }
            }
        }
    }
}