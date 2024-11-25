using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Context (values of variables)
        var context = new Dictionary<string, double>
        {
            { "x", 5 },
            {"y", 3}
        };
        Operand op1 = new Operand("y");
        Operand op2 = new Operand(2);
        // Create the expression: 3 + (2 * x)
        Parse expression = new PlusParse();
        var expr = expression.Divide("1+2+3+4");

        var expr1 = new MultiplyOperator(op1, op2);

        // Evaluate the expression
        double result = expr.Evaluate(context);

        // Output the result
        Console.WriteLine(result);  // Output: 13
    }
}
