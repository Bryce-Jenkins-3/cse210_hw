using System;

class Program
{
    static void Main(string[] args)
    {
        int done = 1;
        int choice;
        while (done != 0)
        {
            Console.WriteLine("Welcom to the Journal!");
            Console.WriteLine("Please Choose one of the following options.");
            Console.WriteLine("0. Quit");
            Console.WriteLine("1. Add journal entry");
            Console.WriteLine("2. Load journal to a file");
            Console.WriteLine("3. Save journal to a file");
            Console.Write("Enter an integer for your choice: ");
            choice = int.Parse(Console.ReadLine());

            Journal journal = new Journal();

            Entry entry = new Entry();
            entry.getentry();

            if (choice == 0)
            {
                done = 1;
            }
            else if (choice == 1)
            {
                Entry entry = new Entry();
                newEntry = entry.getentry();
                journal.entries.add(newEntry);
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else
            {

            }
        }
    }
}