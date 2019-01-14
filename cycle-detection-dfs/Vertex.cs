using System.Collections;
using System.Collections.Generic;

namespace CycleDetection
{
    public class Vertex
    {
        private string name;
        private bool isVisited;
        private bool beingVisited;
        private List<Vertex> adjacentVertecies;
        public Vertex(string name)
        {
            this.name = name;
            this.adjacentVertecies = new List<Vertex>();
        }
        public void addNeighbor(Vertex v)
        {
            this.adjacentVertecies.Add(v);
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public bool IsVisited
        {
            get => isVisited;
            set => isVisited = value;
        }
        public bool BeingVisited
        {
            get => beingVisited;
            set => beingVisited = value;
        }
        public List<Vertex> AdjacentVertecies
        {
            get => adjacentVertecies;
        }
    }
}