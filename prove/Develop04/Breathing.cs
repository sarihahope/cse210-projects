using System;
using System.Collections.Generic;
using System.Threading;


public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
 

    protected override void PerformActivity()
    {
        int _secondsPerPhase = duration / 2;

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(i == 0 ? "Breathe in..." : "Breathe out...");
            for (int j = _secondsPerPhase; j >= 1; j--)
            {
                Thread.Sleep(1000);
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