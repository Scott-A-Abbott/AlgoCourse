using System;
using System.Collections.Generic;

namespace DAG{
    public class AcyclicShortestPath{
        public void ShortestPath(List<Vertex> vertices, Vertex sourceVertex, Vertex targetVertex){
            sourceVertex.Distance = 0;
            TopologicalOrdering topologicalSort = new TopologicalOrdering();
            topologicalSort.makeTopologicalOrder(vertices);

            Stack<Vertex> stack = topologicalSort.GetTopologicalOrder();

            foreach(Vertex actualVertex in stack){

                Console.Write($"{actualVertex.Name} ");
                
                foreach(Edge edge in actualVertex.Adjacencies){
                    Vertex u = edge.StartVertex;
                    Vertex v = edge.TargetVertex;

                    double newDistance = u.Distance + edge.Weight;

                    if(newDistance < v.Distance){
                        v.Distance = newDistance;
                        v.Predecessor = u;
                    }
                }
            }
            if(targetVertex.Distance == Double.MaxValue){
                Console.WriteLine("No shortest path there...");
            }else{
                Console.WriteLine($"Target vertex shortest path: {targetVertex.Distance}");
            }
        }
        public void showShortestPathTo(Vertex targetVertex){
            List<Vertex> list = new List<Vertex>();

            Vertex actualVertex = targetVertex;
            list.Add(actualVertex);

            while(actualVertex.Predecessor != null){
                actualVertex = actualVertex.Predecessor;
                list.Add(actualVertex);
            }
            list.Reverse();
            foreach(Vertex v in list){
                Console.Write($"{v.Name} -> ");
            }
        }
    }
}