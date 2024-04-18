using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.Gemini.Prompt2;

public class DijkstraTests
{
    [Fact]
    public void FindMinDistance_ReturnsCorrectIndex()
    {
        int[] dist = { 8, 1, 4, 6, 12 };
        bool[] sptSet = { false, true, false, false, false };

        int result = Dijkstra.FindMinDistance(dist, sptSet);
        Assert.Equal(1, result);  // Index 1 has the smallest value
    }

    [Fact]
    public void FindMinDistance_AllVisited_ReturnsNegativeOne()
    {
        int[] dist = { 8, 1, 4, 6, 12 }; 
        bool[] sptSet = { true, true, true, true, true };

        int result = Dijkstra.FindMinDistance(dist, sptSet);
        Assert.Equal(-1, result);  
    }
    
    [Fact]
    public void UseDijkstraAlgorithm_SimpleGraph_CalculatesDistances()
    {
        int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            // ... (rest of your graph)
        };

        // You might want to capture PrintSolution output for testing

        Dijkstra.UseDijkstraAlgorithm(graph, 0); // Source vertex 0

        // Assertions on the calculated distances (dist array)
    }

}