using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        DisplayStartingMessage();
        PrepareToBegin();
        PerformActivity();
        DisplayEndingMessage();
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine(description);
        Console.WriteLine("How long, in seconds would you like for your session? ");
        duration = int.Parse(Console.ReadLine());
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed {name} for {duration} seconds.");
        Thread.Sleep(3000);
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    protected abstract void PerformActivity();
}