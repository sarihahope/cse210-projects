using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(new DateTime(2023, 11,11), 25, 4.0));
        activities.Add(new Cycling(new DateTime(2022, 12, 12), 50, 2.5));
        activities.Add(new Swimming(new DateTime(2024, 12, 23), 28, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Summery());
        }
    }
}