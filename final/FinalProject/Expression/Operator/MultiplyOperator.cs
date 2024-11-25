// Multiply operator (*)
public class MultiplyOperator : Operator
{
    public MultiplyOperator(Expression left, Expression right) : base(left, right) {}

    public override double Evaluate(Dictionary<string, double> context)
    {
        return Left.Evaluate(context) * Right.Evaluate(context);
    }
}