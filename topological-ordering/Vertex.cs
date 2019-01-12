using System.Collections;
using System.Collections.Generic;

public class Vertex
{
    private string data;
    public string Data
    {
        get => data;
        set => data = value;
    }
    private bool isVisited;
    public bool IsVisited
    {
        get => isVisited;
        set => isVisited = value;
    }
    private List<Vertex> neighbors;

    public List<Vertex> Neighbors
    {
        get => neighbors;
    }

    public Vertex(string data)
    {
        this.data = data;
        this.neighbors = new List<Vertex>();
    }

    public void addNeighbor(Vertex neighbor)
    {
        this.neighbors.Add(neighbor);
    }

}