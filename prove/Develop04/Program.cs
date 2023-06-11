using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Start a Breathing Activity");
            Console.WriteLine("2. Start a Reflection Activity");
            Console.WriteLine("3. Start a Listing Activity");
            Console.WriteLine("4. Start a Grounding Activity");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Select your choice from the menu:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "4":
                    GroundingActivity groundingActivity = new GroundingActivity();
                    groundingActivity.Start();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}