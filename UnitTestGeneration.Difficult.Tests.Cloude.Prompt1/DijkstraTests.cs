using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Cloude.Prompt1;

public class DijkstraTests
{
    [Fact]
    public void FindMinDistance_ReturnsCorrectIndex()
    {
        // Arrange
        int[] dist = { 1, 5, 3, 8, int.MaxValue };
        bool[] sptSet = { false, false, false, false, false };

        // Act
        int minIndex = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(0, minIndex);
    }

    [Fact]
    public void FindMinDistance_ReturnsMinusOneWhenAllVerticesVisited()
    {
        // Arrange
        int[] dist = { 1, 5, 3, 8 };
        bool[] sptSet = { true, true, true, true };

        // Act
        int minIndex = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(-1, minIndex);
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
        int[] dist = new int[Dijkstra.vertexQuantity];
        Dijkstra.UseDijkstraAlgorithm(graph, src);
        dist.CopyTo(dist, 0);

        // Assert
        Assert.Equal(expectedDistances, dist);
    }
}