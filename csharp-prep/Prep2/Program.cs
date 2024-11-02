using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        if (gradeInt >= 90)
        {
            Console.WriteLine("A");
        }
        else if (gradeInt >= 80)
        {
            Console.WriteLine("B");
        }
        else if (gradeInt >= 70)
        {
            Console.WriteLine("C");
        }
        else if (gradeInt >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}