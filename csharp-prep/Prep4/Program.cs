using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber;
        int sum = 0;
        int count = 0;
        float avg;

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                sum += newNumber;
                count ++;
            } 
        } while (newNumber != 0);

        avg = sum / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is {avg}");
    }
}