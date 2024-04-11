namespace UnitTestGeneration.Easy.App;

// https://github.com/onurcanari/Calculator/blob/master/Calculator.cs
// cy = 4, co = 4
public static class SqrtFunction
{
    public static decimal Sqrt(decimal x, decimal epsilon = 0.0M) {
        if(x<0) throw new OverflowException("Cannot calculate square root from a negative number");

        decimal current = (decimal)Math.Sqrt((double)x), previous;
        do {
            previous=current;
            if(previous==0.0M) return 0;
            current=(previous+x/previous)/2;
        }
        while(Math.Abs(previous-current)>epsilon);
        return current;
    }
}