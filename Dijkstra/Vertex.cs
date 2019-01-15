using System;
using System.Collections.Generic;

namespace Dijkstra
{
    public class Vertex : IComparable<Vertex>
    {
        private string name;
        private List<Edge> adjacentcies;
        private bool visited;
        private Vertex predecessor;
        private double distance = Double.MaxValue;

        public Vertex(string name)
        {
            this.name = name;
            this.adjacentcies = new List<Edge>();
        }
        public void addNeighbor(Edge edge)
        {
            this.adjacentcies.Add(edge);
        }

        public int CompareTo(Vertex otherVertex)
        {
            return this.distance.CompareTo(otherVertex.Distance);
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public List<Edge> Adjacentcies
        {
            get => adjacentcies;
        }
        public Type Visited
        {
            get => visited;
            set => visited = value;
        }
        public Type Predecessor
        {
            get => predecessor;
            set => predecessor = value;
        }
        public Type Distance
        {
            get => distance;
            set => distance = value;
        }
    }
}