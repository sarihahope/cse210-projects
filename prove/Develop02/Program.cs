using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "0";

        Journal journal = new Journal();

            do

            { 
                
                DisplayMenu ();
                Console.Write("Please select an Option: ");
                answer = Console.ReadLine();
                Console.WriteLine();

  
                if (answer == "1")
                {
                    journal.journalAdd();
                }

                if (answer == "2")
                {
                    journal.DisplayEntry();
                }

                if (answer == "3")
                {
                    journal.saveFile();
                }

                if (answer == "4")
                {
                    journal.loadFile();
                }
            }
        while(answer != "5");
    

            static void DisplayMenu()
            {

                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1. Enter an Entry");
                Console.WriteLine("2. Display Journal Entries");
                Console.WriteLine("3. Save Journal Entries");
                Console.WriteLine("4. Load Journal Entries");
                Console.WriteLine("5. Quit");
                Console.WriteLine();
            }
    
    }
}
