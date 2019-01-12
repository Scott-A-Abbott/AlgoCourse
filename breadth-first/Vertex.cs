using System;
using System.Collections.Generic;

public class Vertex
{
    private int data;
    private bool visited;
    private List<Vertex> neighborList;
    public Vertex(int data)
    {
        this.data = data;
        this.neighborList = new List<Vertex>();
    }
    public int Data
    {
        get => data;
        set => data = value;
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
        return $"{data}";
    }
}