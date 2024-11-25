public class InputExpression
{
    private string expression;

    public void SetExpression()
    {
        Console.Write("Enter an expression: ");
        expression = Console.ReadLine();
    }

        public string GetExpression()
    {
        return expression;
    }
}