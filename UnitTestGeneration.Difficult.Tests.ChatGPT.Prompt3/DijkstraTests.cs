using UnitTestGeneration.Difficult.App;
using System;

namespace UnitTestGeneration.Difficult.Tests.ChatGPT.Prompt3;

public class DijkstraTests
{
[Fact]
    public void FindMinDistance_ShouldReturnCorrectMinIndex()
    {
        // Arrange
        int[] dist = { 0, 2, 4, 3 };
        bool[] sptSet = { true, false, false, true };

        // Act
        var minIndex = Dijkstra.FindMinDistance(dist, sptSet);

        // Assert
        Assert.Equal(2, minIndex);
    }

    // [Fact]
    // public void PrintSolution_ShouldPrintCorrectSolution()
    // {
    //     // Arrange
    //     int[] dist = { 0, 2, 4, 3 };
    //     int n = 4;
    //     var expectedOutput = "Rezultat zastosowania Algorytmu Dijkistry:\n" +
    //                          "Wierzchołek     Odległość od korzenia\n" +
    //                          "0 \t\t 0\n" +
    //                          "1 \t\t 2\n" +
    //                          "2 \t\t 4\n" +
    //                          "3 \t\t 3\n";
    //
    //     // Act
    //     using (var consoleOutput = new ConsoleOutput())
    //     {
    //         Dijkstra.PrintSolution(dist, n);
    //         var output = consoleOutput.GetOuput();
    //
    //         // Assert
    //         Assert.Equal(expectedOutput, output);
    //     }
    // }
    //
    // [Fact]
    // public void PrintGraph_ShouldPrintCorrectGraph()
    // {
    //     // Arrange
    //     int[,] graph = { { 0, 1, 2 }, { 1, 0, 3 }, { 2, 3, 0 } };
    //     var expectedOutput = "Algorym Dijkistry został zastosowany dla następującej macierzy:\n" +
    //                          "0 1 2 \n" +
    //                          "1 0 3 \n" +
    //                          "2 3 0 \n\n";
    //
    //     // Act
    //     using (var consoleOutput = new ConsoleOutput())
    //     {
    //         Dijkstra.PrintGraph(graph);
    //         var output = consoleOutput.GetOuput();
    //
    //         // Assert
    //         Assert.Equal(expectedOutput, output);
    //     }
    // }
    //
    // [Fact]
    // public void UseDijkstraAlgorithm_ShouldPrintCorrectResult()
    // {
    //     // Arrange
    //     int[,] graph = {
    //         { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
    //         { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
    //         { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
    //         { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
    //         { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
    //         { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
    //         { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
    //         { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
    //         { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
    //     };
    //     int src = 0;
    //     var expectedOutput = "Rezultat zastosowania Algorytmu Dijkistry:\n" +
    //                          "Wierzchołek     Odległość od korzenia\n" +
    //                          "0 \t\t 0\n" +
    //                          "1 \t\t 4\n" +
    //                          "2 \t\t 12\n" +
    //                          "3 \t\t 19\n" +
    //                          "4 \t\t 21\n" +
    //                          "5 \t\t 11\n" +
    //                          "6 \t\t 9\n" +
    //                          "7 \t\t 8\n" +
    //                          "8 \t\t 14\n";
    //
    //     // Act
    //     using (var consoleOutput = new ConsoleOutput())
    //     {
    //         Dijkstra.UseDijkstraAlgorithm(graph, src);
    //         var output = consoleOutput.GetOuput();
    //
    //         // Assert
    //         Assert.Equal(expectedOutput, output);
    //     }
    // }
}