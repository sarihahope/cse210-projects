using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    protected override void PerformActivity()
    {
        Random random = new Random();

        string _prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(_prompt);
        Thread.Sleep(5000);

        Console.WriteLine("Think about the prompt and start listing items...");
        Thread.Sleep(3000);

        for (int i = 1; i <= duration; i++)
        {
            Console.WriteLine($"Item {i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine($"You have listed {duration} items.");
    }
}