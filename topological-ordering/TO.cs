using System.Collections;
using System.Collections.Generic;

public class TO
{
    private Stack<Vertex> stack = new Stack<Vertex>();
    public Stack<Vertex> Stack
    {
        get => this.stack;
    }

    public void dfs(Vertex root)
    {
        root.IsVisited = true;
        foreach (Vertex neighbor in root.Neighbors)
        {
            if(!neighbor.IsVisited)
            {
                dfs(neighbor);
            }
        }
        stack.Push(root);
    }
}