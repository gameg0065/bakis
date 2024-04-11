namespace UnitTestGeneration.Easy.App;

//https://github.com/scourii/HieloCalculator/blob/main/Hielo/Evaluation.cs
// cy = 1, co = 1
public class Evaluations
{
    public static decimal Evaluate(string expression)
    {
        try{
            System.Data.DataTable table = new System.Data.DataTable(); // Initializes the table,
            table.Columns.Add("expression", string.Empty.GetType(), expression); // Adds the string to table "Expressions"
            System.Data.DataRow row = table.NewRow(); // Gets the math symbols information
            table.Rows.Add(row);
            return decimal.Parse((string)row["expression"]); // executes the operations in the tables.
        }
        catch (FormatException)
        {
            return decimal.Zero;
        }  

    }
}