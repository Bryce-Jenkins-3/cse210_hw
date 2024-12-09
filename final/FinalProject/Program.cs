using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calculator program!\n");
        Console.WriteLine("Input any expression that involves +, -, /, *, ^, and ().");
        Console.WriteLine("Use _ for negative numbers.");
        Console.WriteLine("When you are done enter 0 to quit.\n");

        // Context (values of variables)
        var context = new Dictionary<string, double>
        {
            { "x", 5 },
            {"y", 3}
        };
        while(true)
        {
            InputExpression userInput = new InputExpression();
            userInput.SetExpression();
            string expression = userInput.GetExpression();
            if (expression == "0")
            {
                break;
            }
            else
            {
                var parsedExpression = ExpressionParser.Parse(expression);

                // Evaluate the expression
                double result = parsedExpression.Evaluate(context);

                // Output the result
                Console.WriteLine(result);
            }
        }
    }
}
