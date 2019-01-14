using System;
using System.Collections.Generic;
using static CycleDetection.CycleDetection;

namespace CycleDetection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vertex> list = new List<Vertex>();
            list.Add(new Vertex("1"));
            list.Add(new Vertex("2"));
            list.Add(new Vertex("3"));
            list.Add(new Vertex("4"));
            list.Add(new Vertex("5"));
            list.Add(new Vertex("6"));

            list[0].addNeighbor(list[1]);
            list[1].addNeighbor(list[2]);
            list[2].addNeighbor(list[0]);
            list[3].addNeighbor(list[0]);
            list[3].addNeighbor(list[4]);
            list[4].addNeighbor(list[5]);
            // list[5].addNeighbor(list[3]);

            detectCycle(list);
        }
    }
}