// Plus operator (+)
public class ExponentOperator : Operator
{
    public ExponentOperator(Expression left, Expression right) : base(left, right) {}

    public override double Evaluate(Dictionary<string, double> context)
    {
        return Math.Pow(Left.Evaluate(context), Right.Evaluate(context));
    }
}