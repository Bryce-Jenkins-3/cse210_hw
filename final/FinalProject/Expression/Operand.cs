// Operand class for constants and variables
public class Operand : Expression
{
    private readonly object _value;  // Can be a constant or a variable name (string)

    public Operand(object value)
    {
        _value = value;
    }

    public override double Evaluate(Dictionary<string, double> context)
    {
        if (_value is string variableName)
        {
            // Return the variable value from the context
            return context.ContainsKey(variableName) ? context[variableName] : 0;
        }
        // Return constant value
        return Convert.ToDouble(_value);
    }
}