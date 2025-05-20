using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph = {
                { 0, 10, 0, 30, 100 },
                { 10, 0, 50, 0, 0 },
                { 0, 50, 0, 20, 10 },
                { 30, 0, 20, 0, 60 },
                { 100, 0, 10, 60, 0 }
            };

            int source = 0;
            Dijkstra(graph, source);
        }

        static void Dijkstra(int[,] graph, int source)
        {
            int numVertices = graph.GetLength(0);
            bool[] visited = new bool[numVertices];
            int[] distance = new int[numVertices];
            int[] previous = new int[numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                distance[i] = int.MaxValue;
                previous[i] = -1;
            }

            distance[source] = 0;

            for (int i = 0; i < numVertices - 1; i++)
            {
                int u = MinDistance(distance, visited);
                visited[u] = true;

                for (int v = 0; v < numVertices; v++)
                {
                    if (!visited[v] && graph[u, v] != 0 && distance[u] != int.MaxValue
                        && distance[u] + graph[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graph[u, v];
                        previous[v] = u;
                    }
                }
            }

            for (int i = 0; i < numVertices; i++)
            {
                Console.Write($"Node {source} to Node {i}: Distance = {distance[i]}, Path = ");
                PrintPath(previous, i);
                Console.WriteLine();
            }
        }

        static int MinDistance(int[] distance, bool[] visited)
        {
            int min = int.MaxValue, minIndex = -1;

            for (int v = 0; v < distance.Length; v++)
            {
                if (!visited[v] && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        static void PrintPath(int[] previous, int i)
        {
            if (i == -1)
                return;
            PrintPath(previous, previous[i]);
            Console.Write(i + " ");
        }
    }
}
