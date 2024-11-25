public class PlusParse : Parse
{
    public override Expression Divide(string expression)
    {
        string[] divisions = expression.Split("+");
        PlusOperator plus = new PlusOperator(new Operand(int.Parse(divisions[0])), new Operand(int.Parse(divisions[1])));
        if (divisions.Count() > 2)
        {
            for (int i = 2; divisions.Count() > i; i++)
            {
                plus = new PlusOperator(plus, new Operand(int.Parse(divisions[i])));
            }
        }
        return plus;
    }
}