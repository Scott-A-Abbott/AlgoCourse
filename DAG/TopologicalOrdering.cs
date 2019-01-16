using System;
using System.Collections.Generic;

namespace DAG {
    public class TopologicalOrdering{
        private Stack<Vertex> stack;

        public TopologicalOrdering()
        {
            this.stack = new Stack<Vertex>();
        }
        public void makeTopologicalOrder(List<Vertex> vertices){
            foreach(Vertex v in vertices){
                if(!v.Visited){
                    dfs(v);
                }
            }
        }
        private void dfs(Vertex v)
        {
            foreach(Edge edge in v.Adjacencies){
                if(!edge.TargetVertex.Visited){
                    edge.TargetVertex.Visited = true;
                    dfs(edge.TargetVertex);
                }
            }
            this.stack.Push(v);
        }
        public Stack<Vertex> GetTopologicalOrder(){
            return this.stack;
        }
    }
}