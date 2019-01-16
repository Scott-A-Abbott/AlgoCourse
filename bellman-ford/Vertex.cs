using System;
using System.Collections.Generic;

namespace BellmanFord
{
    public class Vertex
    {
        private string name;
        private bool visited;
        private double distance = Double.MaxValue;
        private Vertex previousVertex;
        private List<Edge> adjacencies;

        public Vertex(string name)
        {
            this.Name = name;
            this.adjacencies = new List<Edge>();
        }

        public string Name { get => name; set => name = value; }
        public bool Visited { get => visited; set => visited = value; }
        public double Distance { get => distance; set => distance = value; }
        public Vertex PreviousVertex { get => previousVertex; set => previousVertex = value; }
        public List<Edge> Adjacencies { get => adjacencies; }

        public void AddNeighbor(Edge neighbor)
        {
            this.adjacencies.Add(neighbor);
        }
    }
}