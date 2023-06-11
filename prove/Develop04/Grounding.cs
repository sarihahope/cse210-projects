using System;
using System.Collections.Generic;
using System.Threading;


public class GroundingActivity : Activity
{

    private List<string> _items;
    private List<string> _prompts;



    public GroundingActivity() : base("Grounding Activity", "This activity will help ground you in the hear and now.")
    {
        _prompts = new List<string>
        {
            "Think of a comfortable place: ",
            "Stop and breath for moment."
        };
    
        _items = new List<string>
        {
            "Think of Five things you can see around you.",
            "Think of Four things you can touch around you.",
            "Think of Three things you can hear.",
            "Think of Two things you can smell.",
            "Think of One thing you can taste."
        };

    }

    protected override void PerformActivity()
    {
        int secondsPerQuestion = duration / _items.Count;
        Random random = new Random();

        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
            Thread.Sleep(3000);

            foreach (string item in _items)
            {
                Console.WriteLine(item);
                Thread.Sleep(secondsPerQuestion * 1000);
                Console.CursorLeft = 0;
                Console.Write("|");
                System.Threading.Thread.Sleep(1000);
                Console.CursorLeft = 0;
                Console.Write("/");
                System.Threading.Thread.Sleep(1000);
                Console.CursorLeft = 0;
                Console.Write("-");
                System.Threading.Thread.Sleep(1000);
                Console.CursorLeft = 0;
                Console.Write("\\");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}