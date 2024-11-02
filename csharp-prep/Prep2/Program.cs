using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter;

        if (gradeInt >= 90)
        {
            letter = "A";
        }
        else if (gradeInt >= 80)
        {
            letter = "B";
        }
        else if (gradeInt >= 70)
        {
            letter = "C";
        }
        else if (gradeInt >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (gradeInt >= 70)
        {
            Console.WriteLine("Congratulations you passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry you didn't pass the line.");
        }
    }
}