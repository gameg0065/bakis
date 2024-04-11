namespace UnitTestGeneration.Moderate.App;

//https://github.com/Mathias007/c-sharp-primary-projects/blob/master/MatrixArray/WSB_Task2/MatrixArray.cs
// cy = 8, co = 21
public class MatrixArray
{
    public static void Matrix()
    {
        string[,] matrixArray = new string[6, 6];

        int matrixWidth = matrixArray.GetLength(0);
        int matrixHeight = matrixArray.GetLength(1);

        if (matrixHeight > 0 && matrixWidth > 0)
        {
            for (int col = 0; col < matrixWidth; col++)
            {
                for (int row = 0; row < matrixHeight; row++)
                {
                    matrixArray[col, row] = (row < matrixHeight / 2) 
                        ? (col < matrixWidth / 2 ? "%" : "#") 
                        : (col < matrixWidth / 2 ? "*" : "+");
                    Console.Write(matrixArray[col, row]);
                }
                Console.Write("\n");
            }
        }
        Console.ReadLine();
    }
}