namespace UnitTestGeneration.Easy.App;
// https://github.com/SyedZeenath/CSharp_codes/tree/master/GeometricShapes/cs_con_GeometricShapes
// cy = 4, co = 0
public static class GeometricShapes
{
    public static class RectangleShape
    {
        public static Tuple<double, double> Area(float length = 12, float breadth = 22)
        {
            return new Tuple<double, double>( length * breadth, 2 * (length + breadth));
        }
    }
    
    public static class TriangleShape
    {
        
        public static  Tuple<double, double> Area(float _base = 5, float height = 13, float side1 = 12, float side2 = 10)
        {
            return new Tuple<double, double>( _base * height / 2, _base + side1 + side2);
        }
    }
    
    public static class SquareShape
    {
        public static Tuple<double, double> Area(float side = 12)
        {
            return new Tuple<double, double>(side * side, 4 * side);
        }
    }
    
    public static class CircleShape
    {
        public static Tuple<double, double> Area(float radius = 20)
        {
            return new Tuple<double, double>(3.14 * radius * radius, 4 * 3.14 * radius);
        }
    }
}