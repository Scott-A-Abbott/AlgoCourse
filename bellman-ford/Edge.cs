using System;

namespace BellmanFord
{
    public class Edge
    {
        private double weight;
        private Vertex startVertex;
        private Vertex targetVertex;

        public Edge(double weight, Vertex startVertex, Vertex targetVertex)
        {
            this.Weight = weight;
            this.StartVertex = startVertex;
            this.TargetVertex = targetVertex;
        }

        public double Weight { get => weight; set => weight = value; }
        public Vertex StartVertex { get => startVertex; set => startVertex = value; }
        public Vertex TargetVertex { get => targetVertex; set => targetVertex = value; }
    }
}