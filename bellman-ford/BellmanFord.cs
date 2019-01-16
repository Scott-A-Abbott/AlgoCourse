using System;
using System.Collections.Generic;

namespace BellmanFord
{
    public class BellmanFord
    {
        private List<Edge> edges;
        private List<Vertex> vertices;

        public BellmanFord(List<Edge> edges, List<Vertex> vertices)
        {
            this.edges = edges;
            this.vertices = vertices;
        }

        public void Run(Vertex sourceVertex)
        {
            sourceVertex.Distance = 0;
            for (int i = 0; i < vertices.Count - 1; i++)
            {
                foreach (Edge edge in edges)
                {
                    Vertex u = edge.StartVertex;
                    Vertex v = edge.TargetVertex;

                    if (u.Distance == Double.MaxValue) continue;

                    double newDistance = u.Distance + edge.Weight;
                    
                    if (newDistance < v.Distance)
                    {
                        v.Distance = newDistance;
                        v.PreviousVertex = u;
                    }
                }
            }
            foreach(Edge edge in edges){
                if(edge.StartVertex.Distance != Double.MaxValue){
                    if(HasCycle(edge)){
                        Console.WriteLine("There has been a negative cycle detected...");
                        return;
                    }
                }
            }
        }

        private bool HasCycle(Edge edge) => edge.StartVertex.Distance + edge.Weight < edge.TargetVertex.Distance;
        public void ShortestPathTo(Vertex targetVertex){
            if(targetVertex.Distance == Double.MaxValue) Console.WriteLine("There is no path from the source to the target.");

            Stack<Vertex> stack = new Stack<Vertex>();

            Vertex actualVertex = targetVertex;
            while(actualVertex != null){
                // Console.Write($"{actualVertex.Name} - ");
                stack.Push(actualVertex);
                actualVertex = actualVertex.PreviousVertex;
            }
            while(stack.Count != 0){
                Console.Write($"{stack.Pop().Name} -> ");
            }
        }
    }
}