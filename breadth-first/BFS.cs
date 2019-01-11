using System;
using System.Collections.Generic;

namespace breadth_first
{
    public class BFS
    {
        public void bfs(Vertex root)
        {
            Queue<Vertex> queue = new Queue<Vertex>();
            root.Visited = true;
            queue.Enqueue(root);

            while ( queue.ToArray().Length > 0 )
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