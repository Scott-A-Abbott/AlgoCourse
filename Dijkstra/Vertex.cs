using System;
using System.Collections.Generic;

namespace Dijkstra
{
    public class Vertex : IComparable<Vertex>
    {
        private string name;
        private List<Edge> adjacencies;
        private bool visited;
        private Vertex predecessor;
        private double distance = Double.MaxValue;

        public Vertex(string name)
        {
            this.name = name;
            this.adjacencies = new List<Edge>();
        }
        public void addNeighbor(Edge edge)
        {
            this.adjacencies.Add(edge);
        }

        public int CompareTo(Vertex otherVertex) => this.distance.CompareTo(otherVertex.Distance);

        public string Name { get => name; set => name = value; }
        public List<Edge> Adjacencies { get => adjacencies; }
        public bool Visited { get => visited; set => visited = value; }
        public Vertex Predecessor { get => predecessor; set => predecessor = value; }
        public double Distance { get => distance; set => distance = value; }
    }
}