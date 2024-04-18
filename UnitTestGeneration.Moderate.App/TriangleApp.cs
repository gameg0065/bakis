namespace UnitTestGeneration.Moderate.App;
// https://github.com/M1X3Rr/Shape_Drawer/blob/master/MiniZadanie%20%201%20GUI/ShapeCreation.cs
// cy = 7, co = 6
public class TriangleApp
{
    internal class Triangle
    {
        private int height;

        public Triangle(int height)
        {
            this.height = height;
        }
        
        public void DrawPyramid()
        {
            for (int i = 1; i <= this.height; i++)
            {
                // Print spaces to center the pyramid
                for (int j = 0; j < this.height - i; j++)
                {
                    Console.Write(" ");
                }

                // Print asterisks for the pyramid
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }

    static void CreatePyramid(int height)
    {
        if (height == -1)
        {
            Console.WriteLine("Operation canceled.");
            return; // exit the method
        }
        Triangle pyramid = new Triangle(height);
        Console.WriteLine($"Pyramid created with height: {height}\n");
        pyramid.DrawPyramid();

        Console.WriteLine("\nPress any key to continue");
        Console.ReadLine();
    }
}