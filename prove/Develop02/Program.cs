using System;

class Program
{
    static void Main(string[] args)
    {
        int done = 1;
        int choice;

        Journal journal = new Journal();

        while (done != 0)
        {
            Console.WriteLine("Welcome to the Journal!");
            Console.WriteLine("Please Choose one of the following options.");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Add journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Load journal to a file");
            Console.WriteLine("4. Save journal to a file");
            Console.Write("Enter an integer for your choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 0) //end the program
            {
                done = choice;
            }
            else if (choice == 1) //add an entry to the journal
            {
                journal.NewEntry();
            }
            else if (choice == 2) // Display entries
            {
                journal.DisplayEntries();
            }
            else if (choice == 3) // load the journal to a file
            {
                journal.LoadFile();
            }
            else if (choice == 4) // save the journal to a file
            {
                journal.SaveFile();
            }
            else
            {
                Console.WriteLine("Sorry that number is not an option.");
            }
        }
    }
}