using System;
using System.Collections.Generic;

public class EternalGoal : Goals
{
    public EternalGoal(string _name, int _pointsGained) : base(_name, _pointsGained)
    {
    }

    public override void Complete()
    {
        Console.WriteLine($"You recorded progress for eternal goal '{_name}'. You earned {_pointsGained} points.");
    }
}
