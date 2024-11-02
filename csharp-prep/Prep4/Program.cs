using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float newNumber;
        float sum = 0;
        float count = 0;
        float avg;

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            newNumber = float.Parse(Console.ReadLine());
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