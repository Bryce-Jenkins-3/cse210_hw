// Abstract class for operators
public abstract class Operator : Expression
{
    protected Expression Left { get; }
    protected Expression Right { get; }

    protected Operator(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
}