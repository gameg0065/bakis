namespace UnitTestGeneration.Moderate.App;
// https://github.com/onurcanari/Calculator/blob/master/Calculator.cs
// cy = 8, co = 7
public class PostfixEvaluation
{
    private readonly Dictionary<string, (string symbol, int predence, bool rightAssociative)> operators =
        new (string symbol, int predence, bool rightAssociative)[] {
            ("^", 4, true),
            ("×", 3, false),
            ("÷", 3, false),
            ("+", 2, false),
            ("-", 2, false)
        }.ToDictionary(op => op.symbol);
    
    public string EvaluatePostix(List<string> postfix) {
        decimal temp,topStack, retVal=0;
        var stack = new Stack<string>();
        foreach(string s in postfix) {
            if(Decimal.TryParse(s,out _)) {
                stack.Push(s);
            } else if(operators.TryGetValue(s,out var op)) {
                Decimal.TryParse(stack.Pop(), out topStack);
                Decimal.TryParse(stack.Pop(), out temp);
                switch(s) {
                    case "+":
                        retVal=Decimal.Add(temp, topStack);
                        break;
                    case "-":
                        retVal=Decimal.Subtract(temp, topStack);
                        break;
                    case "÷":
                        retVal=Decimal.Divide(temp, topStack);
                        break;
                    case "×":
                        retVal=Decimal.Multiply(temp, topStack);
                        break;
                    default:
                        retVal=-987656789;
                        break;
                }
                stack.Push(retVal.ToString());
            }
        }
        return stack.Pop();
    }
}