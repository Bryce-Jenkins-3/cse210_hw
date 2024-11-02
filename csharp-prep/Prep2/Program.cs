using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");

        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string letter;
        string sign;

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

        if (gradeInt % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradeInt % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your letter grade is {letter}{sign}.");

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