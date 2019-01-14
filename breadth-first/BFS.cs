using System;
using System.Collections.Generic;

namespace BreadthFirst
{
    public class BFS
    {
        public static void bfs(Vertex root)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            root.Visited = true;
            queue.Enqueue(root);

            while (queue.ToArray().Length > 0)
            {
                Vertex actualVertex = queue.Dequeue();
                Console.WriteLine($"{actualVertex.Data} ");

                foreach (var v in actualVertex.NeighborList)
                {
                    v.Visited = true;
                    queue.Enqueue(v);
                }
            }
        }
    }
}