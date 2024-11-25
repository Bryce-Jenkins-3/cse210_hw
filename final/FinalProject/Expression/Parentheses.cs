// Parentheses to group expressions
public class Parentheses : Expression
{
    private readonly Expression _innerExpression;

    public Parentheses(Expression innerExpression)
    {
        _innerExpression = innerExpression;
    }

    public override double Evaluate(Dictionary<string, double> context)
    {
        return _innerExpression.Evaluate(context);
    }
}