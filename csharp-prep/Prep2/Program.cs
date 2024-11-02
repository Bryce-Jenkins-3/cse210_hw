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
            Console.WriteLine("Your have an A");
        }
        else if (gradeInt >= 80)
        {
            Console.WriteLine("You have a B");
        }
        else if (gradeInt >= 70)
        {
            Console.WriteLine("You have a C");
        }
        else if (gradeInt >= 60)
        {
            Console.WriteLine("You have a D");
        }
        else
        {
            Console.WriteLine("You have an F");
        }

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