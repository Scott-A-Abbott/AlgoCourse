using System;
using System.Collections;
using System.Collections.Generic;

namespace Dijkstra
{
    public static class Dijkstra
    {
        public static void computePaths(Vertex sourceVertex)
        {
            sourceVertex.Distance = 0;
            PriorityQueue<Vertex> priorityQueue = new PriorityQueue<Vertex>();
            priorityQueue.Add(sourceVertex);

            while (!priorityQueue.IsEmpty())
            {
                Vertex actualVertex = priorityQueue.Shift();
                foreach (Edge edge in actualVertex.Adjacentcies)
                {
                    Vertex v = edge.TargetVertex;
                    double newDistance = actualVertex.Distance + edge.Weight;

                    if (newDistance < v.Distance)
                    {
                        priorityQueue.Remove(v);
                        v.Distance = newDistance;
                        v.Predecessor = actualVertex;
                        priorityQueue.Add(v);
                    }
                }
            }
        }
        public static List<Vertex> GetShortestPathTo(Vertex target)
        {
            List<Vertex> shortestPathToTarget = new List<Vertex>();
            for (Vertex vertex = target; vertex != null; vertex = vertex.Predecessor)
            {
                shortestPathToTarget.Add(vertex);
            }
            shortestPathToTarget.Reverse();
            return shortestPathToTarget;
        }
    }
}