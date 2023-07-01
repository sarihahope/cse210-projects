using System;
using System.Collections.Generic;
namespace GoalTracker

{  


public class ChecklistGoal : Goals
{
    public int TargetCount { get; }
    public int CurrentCount { get; private set; }

    public ChecklistGoal(string _name, int _pointsGained, int _targetCount) : base(_name, _pointsGained)
    {
        TargetCount = _targetCount;
        CurrentCount = 0;
    }

    public override void Complete()
    {
        CurrentCount++;
        Console.WriteLine($"You recorded progress for '{_name}'. You have {_pointsGained} points.");

        if (CurrentCount >= TargetCount)
        {
            Completed = true;
            Console.WriteLine($"'{_name}' completed {TargetCount} times. You have {_pointsGained} points.");
        }
    }
}
}
