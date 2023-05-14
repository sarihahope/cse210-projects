using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMenu ();
        Console.Write("Please select an Option: ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
            {
                letter = "A";
            }
            else if (percent >= 80)
            {
                letter = "B";
            }
            else if (percent >= 70)
            {
                letter = "C";
            }
            else if (percent >= 60)
            {
                letter = "D";
            }
            else 
            {
                letter = "F";
            }
            Console.WriteLine($"Your grade is: {letter}");

            if (percent >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }


        static void DisplayMenu()
        {

            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Enter an Entry");
            Console.WriteLine("2. Display Journal Entries");
            Console.WriteLine("3. Save Journal Entries");
            Console.WriteLine("4. Load Journal Entries");
            Console.WriteLine("5. Quit");
        }

    }
}