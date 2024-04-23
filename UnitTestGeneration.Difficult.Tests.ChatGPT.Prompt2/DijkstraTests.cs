using UnitTestGeneration.Difficult.App;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt2;

public class DijkstraTests
{
    [Fact]
    public void FindMinDistance_ShouldReturnMinIndex_WhenGivenDistancesAndSptSet()
    {
        // Arrange
        int[] dist = { 0, 2, 4, 3 };
        bool[] sptSet = { false, false, false, false };

        // Act
        int result = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void PrintSolution_ShouldPrintCorrectly_WhenGivenDistancesAndVertexQuantity()
    {
        // Arrange
        int[] dist = { 0, 2, 4, 3 };
        int vertexQuantity = 4;
        var consoleOutput = new System.IO.StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        Dijkstra.PrintSolution(dist, vertexQuantity);
        var printedText = consoleOutput.ToString();

        // Assert
        Assert.Contains("Rezultat zastosowania Algorytmu Dijkistry:", printedText);
        Assert.Contains("Wierzchołek     Odległość od korzenia", printedText);
        Assert.Contains("0 \t\t 0", printedText);
        Assert.Contains("1 \t\t 2", printedText);
        Assert.Contains("2 \t\t 4", printedText);
        Assert.Contains("3 \t\t 3", printedText);
    }

    [Fact]
    public void UseDijkstraAlgorithm_ShouldPrintCorrectly_WhenGivenGraphAndSourceVertex()
    {
        // Arrange
        int[,] graph = { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                         { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                         { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                         { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                         { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                         { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                         { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                         { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                         { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
        int src = 0;
        var consoleOutput = new System.IO.StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        Dijkstra.UseDijkstraAlgorithm(graph, src);
        var printedText = consoleOutput.ToString();

        // Assert
        Assert.Contains("Rezultat zastosowania Algorytmu Dijkistry:", printedText);
        Assert.Contains("Wierzchołek     Odległość od korzenia", printedText);
        Assert.Contains("0 \t\t 0", printedText);
        Assert.Contains("1 \t\t 4", printedText);
        Assert.Contains("2 \t\t 12", printedText);
        Assert.Contains("3 \t\t 19", printedText);
        Assert.Contains("4 \t\t 21", printedText);
        Assert.Contains("5 \t\t 11", printedText);
        Assert.Contains("6 \t\t 9", printedText);
        Assert.Contains("7 \t\t 8", printedText);
        Assert.Contains("8 \t\t 14", printedText);
    }

    [Fact]
    public void PrintGraph_ShouldPrintCorrectly_WhenGivenGraph()
    {
        // Arrange
        int[,] graph = { { 0, 1, 2 },
                         { 1, 0, 3 },
                         { 2, 3, 0 } };
        var consoleOutput = new System.IO.StringWriter();
        Console.SetOut(consoleOutput);

        // Act
        Dijkstra.PrintGraph(graph);
        var printedText = consoleOutput.ToString();

        // Assert
        Assert.Contains("Algorym Dijkistry został zastosowany dla następującej macierzy:", printedText);
        Assert.Contains("0 1 2", printedText);
        Assert.Contains("1 0 3", printedText);
        Assert.Contains("2 3 0", printedText);
    }
}