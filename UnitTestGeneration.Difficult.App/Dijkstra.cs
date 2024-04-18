namespace UnitTestGeneration.Difficult.App;

// https://github.com/Mathias007/c-sharp-primary-projects/blob/master/Dijkistra/Dijkistra/Dijkistra.cs
// cy = 19, co = 20

public static class Dijkstra
{
    public static readonly int vertexQuantity = 9;

    public static int FindMinDistance(int[] dist,bool[] sptSet)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < vertexQuantity; v++)
            if (sptSet[v] == false && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }

        return minIndex;
    }

    public static void PrintSolution(int[] dist, int n)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Rezultat zastosowania Algorytmu Dijkistry:");
        Console.Write("Wierzchołek     Odległość "
                      + "od korzenia\n");
        for (int i = 0; i < vertexQuantity; i++)
            Console.Write(i + " \t\t " + dist[i] + "\n");

        Console.ForegroundColor = ConsoleColor.Gray;
    }

    public static void UseDijkstraAlgorithm(int[,] graph, int src)
    {
        int[] dist = new int[vertexQuantity]; 
        bool[] sptSet = new bool[vertexQuantity];

        for (int i = 0; i < vertexQuantity; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[src] = 0;

        for (int count = 0; count < vertexQuantity - 1; count++)
        {
            int u = FindMinDistance(dist, sptSet);

            sptSet[u] = true;

            for (int v = 0; v < vertexQuantity; v++)
                if (!sptSet[v] && graph[u, v] != 0 &&
                     dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    dist[v] = dist[u] + graph[u, v];
        }

        PrintSolution(dist, vertexQuantity);
    }

    public static void PrintGraph(int[,] graph)
    {
        int graphWidth = graph.GetLength(0);
        int graphHeight = graph.GetLength(1);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Algorym Dijkistry został zastosowany dla następującej macierzy:");
        if (graphHeight > 0 && graphWidth > 0)
        {
            for (int col = 0; col < graphWidth; col++)
            {
                for (int row = 0; row < graphHeight; row++)
                {
                    Console.Write($"{graph[col, row]} ");
                }
                Console.Write("\n");
            }
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n");
    }
}