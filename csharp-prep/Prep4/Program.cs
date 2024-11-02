using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber;
        int sum = 0;

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                sum += newNumber;
            } 
        } while (newNumber != 0);

        Console.WriteLine($"The sum is: {sum}");
    }
}