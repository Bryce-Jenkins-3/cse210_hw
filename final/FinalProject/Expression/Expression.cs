// Abstract class representing any expression
public abstract class Expression
{
    public abstract double Evaluate(Dictionary<string, double> context);
}