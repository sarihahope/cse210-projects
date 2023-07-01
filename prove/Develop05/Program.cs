using System;
using System.Collections.Generic;
public class Program
{

    private static void Main()
    {

        bool exitProgram = false;
        while (!exitProgram)
        {
            Console.WriteLine("Eternal Quest");
            Console.WriteLine("1. View your Goals");
            Console.WriteLine("2. Add your Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save your Goals");
            Console.WriteLine("5. Exit");
            Console.Write("Please enter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Goals.ViewGoals();
                    break;
                case "2":
                    Goals.AddGoal();
                    break;
                case "3":
                    Goals.RecordEvent();
                    break;
                case "4":
                    Goals.SaveGoals();
                    break;
                case "5":
                    exitProgram = true;
                    break;
                default:
                    Console.WriteLine("Wrong number, try again");
                    break;
            }

            Console.WriteLine();
        }
    }
}



