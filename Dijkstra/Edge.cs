using System;

namespace Dijkstra
{
    public class Edge
    {
        private double weight;
        private Vertex startVertex;
        private Vertex targetVertex;
        public Edge(double weight, Vertex startVertex, Vertex targetVertex)
        {
            this.weight = weight;
            this.startVertex = startVertex;
            this.targetVertex = targetVertex;
        }
        public double Weight
        {
            get => weight;
            set => weight = value;
        }
        public Vertex StartVertex
        {
            get => startVertex;
            set => startVertex = value;
        }
        public Vertex targetVertex
        {
            get => targetVertex;
            set => targetVertex = value;
        }
    }
}