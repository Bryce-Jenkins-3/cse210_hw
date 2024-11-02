using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber;
        int guess;
        Console.Write("What is the magic number? ");
        magicNumber = int.Parse(Console.ReadLine());
        
        do
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higer");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

    }
}