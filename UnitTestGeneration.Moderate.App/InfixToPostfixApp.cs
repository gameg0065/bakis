namespace UnitTestGeneration.Moderate.App;

//https://github.com/onurcanari/Calculator/blob/master/Calculator.cs
// cy = 15, co = 23

public class InfixToPostfixApp
{
    private readonly Dictionary<string, (string symbol, int predence, bool rightAssociative)> operators =
        new (string symbol, int predence, bool rightAssociative)[] {
            ("^", 4, true),
            ("×", 3, false),
            ("÷", 3, false),
            ("+", 2, false),
            ("-", 2, false)
        }.ToDictionary(op => op.symbol);
    
    public List<string> InfixToPostfix(string infix) {
        string[] tokens = infix.Split(' ');
        Stack<string> stack = new Stack<string>();
        List<string> postfix = new List<string>();
        foreach(string token in tokens) {
            if(Decimal.TryParse(token, out _)) {
                postfix.Add(token);
            } else if(operators.TryGetValue(token, out var op1)) {
                while(stack.Count > 0 && operators.TryGetValue(stack.Peek(), out var op2)){
                    int c = op1.predence.CompareTo(op2.predence);
                    if(c < 0 || !op1.rightAssociative && c<=0) {
                        postfix.Add(stack.Pop());
                    } else {
                        break;
                    }
                }
                stack.Push(token);
            } else if(token=="(") {
                stack.Push("(");
            } else if(token ==")") {
                while(stack.Count > 0 && stack.Peek() != "(") {
                    postfix.Add(stack.Pop());
                }
                postfix.Add(stack.Pop());
            }
        }
        while(stack.Count >0) {
            postfix.Add(stack.Pop());
        }
        foreach(string s in postfix) {
            Console.Write(s+" ");
        }
        Console.WriteLine("");
        return postfix;   
    }
}