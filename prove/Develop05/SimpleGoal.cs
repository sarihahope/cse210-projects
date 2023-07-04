using System;
using System.Collections.Generic;


public class SimpleGoal : Goals
{
    public SimpleGoal(string _name, int _pointsGained) : base(_name, _pointsGained)
    {
    }

    public override void Complete()
    {
        Completed = true;
        Console.WriteLine($" '{_name}' has been completed, you earned {_pointsGained} points.");
    }
}
