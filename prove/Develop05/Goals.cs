using System;
using System.Collections.Generic;
namespace GoalTracker

{    
    public abstract class Goals
    {
    public string _name { get; set; }
    public int _pointsGained { get; set; }
    public bool Completed { get; set;}

    private static List<Goals> _goals = new List<Goals>();

        public Goals(string _name, int _pointsGained)
        {
            _name = _nameOfGoal;
            _pointsGained = _points;

        }


        public static void ViewGoals()
         {


                if (_goals.Count == 0)
                {
                    Console.WriteLine("There are no goals");
                }
                else
                {
                    Console.WriteLine("Goals:");
                    foreach (var goal in _goals)
                {
                    string completionStatus = goal.Completed ? "[X]" : "[ ]";
                    string goalInfo = goal is ChecklistGoal checklistGoal
                        ? $"{completionStatus} {goal._name} (Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times)"
                        : $"{completionStatus} {goal._name}";

                    Console.WriteLine(goalInfo);
                }
                }
         }


        public abstract void Complete();


        public static void AddGoal()
        {
            Console.WriteLine("Goal Types:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Please enter a goal:  ");
            string goalTypeChoice = Console.ReadLine();

            Console.Write("Enter goal name: ");
            string _goalName = Console.ReadLine();

            Console.Write("Enter goal value: ");
            int _goalValue = Convert.ToInt32(Console.ReadLine());

        switch (goalTypeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(_goalName, _goalValue));
                Console.WriteLine("Simple goal added.");
                break;
            case "2":
                _goals.Add(new EternalGoal(_goalName, _goalValue));
                Console.WriteLine("Eternal goal added.");
                break;
            case "3":
                Console.Write("Enter target count: ");
                int _targetCount = Convert.ToInt32(Console.ReadLine());
                _goals.Add(new ChecklistGoal(_goalName, _goalValue, _targetCount));
                Console.WriteLine("Goal added.");
                break;
            default:
                Console.WriteLine("Goal incorrect.");
                break;
        }
    }

    public static void RecordEvent()
    {
        Console.Write("Enter the index of the goal to record an event: ");
        int _goalIndex = Convert.ToInt32(Console.ReadLine());

        if (_goalIndex >= 0 && _goalIndex < _goals.Count)
        {
            Goals goal = _goals[_goalIndex];
            goal.Complete();
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public static void SaveGoals()
    {

        Console.WriteLine("Saved.");
    }

    public static void LoadGoals()
    {
        
        Console.WriteLine("Loaded.");
    }
    }
    }



