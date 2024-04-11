namespace UnitTestGeneration.Moderate.App;

// https://github.com/Kavosian-Microsoft/Graphical_Calculator/blob/master/Visual_Calculator/Visual_Calculator/Form1.cs
// cy = 6, co = 1
public class VisualCalculator
{
    public enum Calculator_Opertaions
    {
        none = -1,
        add = 0,
        subtract = 1,
        multiplicate = 2,
        divide = 3,
    }
    
    public static double BtnEnter_Click(double dblNum1, double dblNum2, Calculator_Opertaions _operation)
    {
        
        switch (_operation)
        {
            case Calculator_Opertaions.none:
                break;
            case Calculator_Opertaions.add:
                return dblNum1 + dblNum2;
            case Calculator_Opertaions.subtract:
                return dblNum1 - dblNum2;
            case Calculator_Opertaions.multiplicate:
                return dblNum1 * dblNum2;
            case Calculator_Opertaions.divide:
                return dblNum1 / dblNum2;
            default:
                return 0;
        }
        return 0;
    }
}