using System;
using System.Collections.Generic;

public class Vertex
{
    private string name;
    private bool visited = false;
    private List<Vertex> neighborList;
    public Vertex(string name)
    {
        this.name = name;
        this.neighborList = new List<Vertex>();
    }
    public string Name
    {
        get => name;
        set => name = value;
    }
    public bool Visited
    {
        get => visited;
        set => visited = value;
    }
    public List<Vertex> NeighborList
    {
        get => neighborList;
        set => neighborList = value;
    }
    public void addNeighborVertex(Vertex vertex)
    {
        this.neighborList.Add(vertex);
    }
    //Override
    public String toString()
    {
        return this.name;
    }
}