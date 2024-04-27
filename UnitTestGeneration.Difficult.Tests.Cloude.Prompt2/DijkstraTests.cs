using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt2;

public class DijkstraTests
{
[Fact]
    public void FindMinDistance_NoUnvisitedVertices_ReturnsNegativeOne()
    {
        // Arrange
        int[] dist = Enumerable.Repeat(int.MaxValue, Dijkstra.vertexQuantity).ToArray();
        bool[] sptSet = Enumerable.Repeat(true, Dijkstra.vertexQuantity).ToArray();

        // Act
        int result = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void FindMinDistance_SomeUnvisitedVertices_ReturnsMinimumDistanceVertex()
    {
        // Arrange
        int[] dist = { 5, 2, int.MaxValue, 7, int.MaxValue, 1, int.MaxValue, int.MaxValue, int.MaxValue };
        bool[] sptSet = { false, false, false, false, true, false, true, true, true };

        // Act
        int result = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void UseDijkstraAlgorithm_SourceVertexZero_CorrectDistances()
    {
        // Arrange
        int[,] graph = {
            {0, 4, 0, 0, 0, 0, 0, 8, 0},
            {4, 0, 8, 0, 0, 0, 0, 11, 0},
            {0, 8, 0, 7, 0, 4, 0, 0, 2},
            {0, 0, 7, 0, 9, 14, 0, 0, 0},
            {0, 0, 0, 9, 0, 10, 0, 0, 0},
            {0, 0, 4, 14, 10, 0, 2, 0, 0},
            {0, 0, 0, 0, 0, 2, 0, 1, 6},
            {8, 11, 0, 0, 0, 0, 1, 0, 7},
            {0, 0, 2, 0, 0, 0, 6, 7, 0}
        };
        int src = 0;

        // Act
        Dijkstra.UseDijkstraAlgorithm(graph, src);

        // Assert
        // Verify the distances from source vertex 0
        int[] expectedDistances = { 0, 4, 12, 19, 21, 11, 9, 8, 14 };
        int[] actualDistances = new int[Dijkstra.vertexQuantity];
        for (int i = 0; i < Dijkstra.vertexQuantity; i++)
        {
            actualDistances[i] = graph[src, i];
        }
        Assert.Equal(expectedDistances, actualDistances);
    }

    [Fact]
    public void PrintSolution_ValidInput_PrintsCorrectly()
    {
        // Arrange
        int[] dist = { 0, 4, 12, 19, 21, 11, 9, 8, 14 };
        int n = Dijkstra.vertexQuantity;

        // Act
        var console = new System.IO.StringWriter();
        Console.SetOut(console);
        Dijkstra.PrintSolution(dist, n);
        string output = console.ToString();

        // Assert
        string expectedOutput = "Rezultat zastosowania Algorytmu Dijkistry:\r\nWierzchołek Odległość od korzenia\r\n" +
                                "0 		 0\r\n1 		 4\r\n2 		 12\r\n3 		 19\r\n4 		 21\r\n5 		 11\r\n" +
                                "6 		 9\r\n7 		 8\r\n8 		 14\r\n";
        Assert.Equal(expectedOutput, output);
    }

    [Fact]
    public void PrintGraph_ValidInput_PrintsCorrectly()
    {
        // Arrange
        int[,] graph = {
            {0, 4, 0, 0, 0, 0, 0, 8, 0},
            {4, 0, 8, 0, 0, 0, 0, 11, 0},
            {0, 8, 0, 7, 0, 4, 0, 0, 2},
            {0, 0, 7, 0, 9, 14, 0, 0, 0},
            {0, 0, 0, 9, 0, 10, 0, 0, 0},
            {0, 0, 4, 14, 10, 0, 2, 0, 0},
            {0, 0, 0, 0, 0, 2, 0, 1, 6},
            {8, 11, 0, 0, 0, 0, 1, 0, 7},
            {0, 0, 2, 0, 0, 0, 6, 7, 0}
        };

        // Act
        var console = new System.IO.StringWriter();
        Console.SetOut(console);
        Dijkstra.PrintGraph(graph);
        string output = console.ToString();

        // Assert
        string expectedOutput = "Algorym Dijkistry został zastosowany dla następującej macierzy:\r\n" +
                                "0 4 0 0 0 0 0 8 0 \r\n4 0 8 0 0 0 0 11 0 \r\n0 8 0 7 0 4 0 0 2 \r\n" +
                                "0 0 7 0 9 14 0 0 0 \r\n0 0 0 9 0 10 0 0 0 \r\n0 0 4 14 10 0 2 0 0 \r\n" +
                                "0 0 0 0 0 2 0 1 6 \r\n8 11 0 0 0 0 1 0 7 \r\n0 0 2 0 0 0 6 7 0 \r\n\r\n";
        Assert.Equal(expectedOutput, output);
    }
}