using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Principal;

public class ExpressionParser
{
    public static Expression Parse(string expression)
    {
        // Tokenize the input expression into numbers, operators, and parentheses
        var tokens = Tokenize(expression);

        // Initialize stacks for the output (AST nodes) and operators
        var output = new Stack<Expression>(); // Holds expressions like Operand or Operator
        var operators = new Stack<string>();  // Holds operators and parentheses

        // Process each token
        foreach (var token in tokens)
        {
            if (IsNumber(token))
            {
                ProcessNumber(token, output);
            }
            else if (IsOperator(token))
            {
                ProcessOperator(token, operators, output);
            }
            else if (IsOpeningParenthesis(token))
            {
                operators.Push(token);
            }
            else if (IsClosingParenthesis(token))
            {
                ProcessClosingParenthesis(operators, output);
            }
        }

        // Apply remaining operators in the stack
        ProcessRemainingOperators(operators, output);

        // Return the final expression
        return GetFinalExpression(output);
    }

    // Helper Methods

    // Check if the token is a number
    private static bool IsNumber(string token)
    {
        return double.TryParse(token, NumberStyles.Any, CultureInfo.InvariantCulture, out _);
    }

    // Check if the token is an operator
    private static bool IsOperator(string token)
    {
        return token == "+" || token == "-" || token == "*" || token == "/" || token == "^";
    }

    // Check if the token is an opening parenthesis
    private static bool IsOpeningParenthesis(string token)
    {
        return token == "(";
    }

    // Check if the token is a closing parenthesis
    private static bool IsClosingParenthesis(string token)
    {
        return token == ")";
    }

    // Process a number token
    private static void ProcessNumber(string token, Stack<Expression> output)
    {
        double number = double.Parse(token, CultureInfo.InvariantCulture);
        Operand operand = new Operand(number);
        output.Push(operand);
    }

    // Process an operator token
    private static void ProcessOperator(string token, Stack<string> operators, Stack<Expression> output)
    {
        while (operators.Count > 0 && GetPrecedence(operators.Peek()) >= GetPrecedence(token))
        {
            ApplyOperator(output, operators.Pop());
        }
        operators.Push(token);
    }

    // Process a closing parenthesis token
    private static void ProcessClosingParenthesis(Stack<string> operators, Stack<Expression> output)
    {
        while (operators.Count > 0 && !IsOpeningParenthesis(operators.Peek()))
        {
            ApplyOperator(output, operators.Pop());
        }

        if (operators.Count > 0 && IsOpeningParenthesis(operators.Peek()))
        {
            operators.Pop(); // Discard the opening parenthesis
        }
        else
        {
            throw new ArgumentException("Mismatched parentheses");
        }
    }

    // Apply remaining operators in the stack
    private static void ProcessRemainingOperators(Stack<string> operators, Stack<Expression> output)
    {
        while (operators.Count > 0)
        {
            ApplyOperator(output, operators.Pop());
        }
    }

    // Ensure exactly one expression remains in the output stack and return it
    private static Expression GetFinalExpression(Stack<Expression> output)
    {
        if (output.Count != 1)
        {
            throw new InvalidOperationException("Invalid expression");
        }
        return output.Pop();
    }

    // Apply an operator to the top two expressions in the output stack
    private static void ApplyOperator(Stack<Expression> output, string op)
    {
        Expression right = output.Pop();
        Expression left = output.Pop();

        if (op == "+")
        {
            output.Push(new PlusOperator(left, right));
        }
        else if (op == "-")
        {
            output.Push(new SubtractOperator(left, right));
        }
        else if (op == "*")
        {
            output.Push(new MultiplyOperator(left, right));
        }
        else if (op == "/")
        {
            output.Push(new DivideOperator(left, right));
        }
        else if (op == "^")
        {
            output.Push(new ExponentOperator(left, right));
        }
        else
        {
            throw new NotSupportedException($"Operator {op} is not supported");
        }
    }

    // Get the precedence of operators
    private static int GetPrecedence(string op)
    {
        if (op == "+" || op == "-") return 1;
        if (op == "*" || op == "/") return 2;
        if (op == "^") return 3;
        return 0;
    }

    // Tokenize the input expression
    private static List<string> Tokenize(string expression)
    {
        var tokens = new List<string>();
        int length = expression.Length;
        for (int i = 0; i < length;)
        {
            char ch = expression[i];
                if (char.IsDigit(ch) || ch == '.' || ch == '_')
                {   
                        int start = i;
                        while (i < length && (char.IsDigit(expression[i]) || expression[i] == '.' || expression[i] == '_'))
                        {
                            i++;
                        }
                        string token = expression.Substring(start, i - start);
                        if (token[0] == '_')
                        {
                            token = "-" + token.Substring(1, token.Length - 1);
                        }
                        tokens.Add(token);
                }
                else if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '^')
                {
                    tokens.Add(ch.ToString());
                    i++;
                }
                else if (ch == '(' || ch == ')')
                {
                    tokens.Add(ch.ToString());
                    i++;
                }
                else if (char.IsWhiteSpace(ch))
                {
                    i++;
                }
                else
                {
                    throw new ArgumentException($"Invalid character: {ch}");
                }
            }
        return tokens;
    }
}