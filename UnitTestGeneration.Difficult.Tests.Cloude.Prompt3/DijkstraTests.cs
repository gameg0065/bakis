using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt3;

public class DijkstraTests
{
[Fact]
    public void FindMinDistance_ReturnsMinIndex()
    {
        // Arrange
        int[] dist = { 5, 3, 10, int.MaxValue, 7 };
        bool[] sptSet = { false, false, false, false, false };
        int expectedIndex = 1;

        // Act
        int minIndex = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(expectedIndex, minIndex);
    }

    [Fact]
    public void FindMinDistance_ReturnsMinIndexWhenAllVerticesAreVisited()
    {
        // Arrange
        int[] dist = { 5, 3, 10, int.MaxValue, 7 };
        bool[] sptSet = { true, true, true, true, true };
        int expectedIndex = -1;

        // Act
        int minIndex = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(expectedIndex, minIndex);
    }

    [Fact]
    public void FindMinDistance_HandlesEmptyDistanceArray()
    {
        // Arrange
        int[] dist = Array.Empty<int>();
        bool[] sptSet = Array.Empty<bool>();
        int expectedIndex = -1;

        // Act
        int minIndex = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(expectedIndex, minIndex);
    }

    [Fact]
    public void UseDijkstraAlgorithm_HandlesEmptyGraph()
    {
        // Arrange
        int[,] graph = new int[0, 0];
        int src = 0;

        // Act
        Dijkstra.UseDijkstraAlgorithm(graph, src);

        // Assert (no exceptions thrown)
    }

    [Fact]
    public void UseDijkstraAlgorithm_ComputesCorrectDistances()
    {
        // Arrange
        int[,] graph = {
            { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
        };
        int src = 0;
        int[] expectedDistances = { 0, 4, 12, 19, 21, 11, 9, 8, 14 };

        // Act
        int[] distances = new int[Dijkstra.vertexQuantity];
        Dijkstra.UseDijkstraAlgorithm(graph, src);

        // Assert
        Assert.Equal(expectedDistances, distances);
    }

    [Fact]
    public void PrintGraph_HandlesEmptyGraph()
    {
        // Arrange
        int[,] graph = new int[0, 0];

        // Act
        Dijkstra.PrintGraph(graph);

        // Assert (no exceptions thrown)
    }
}