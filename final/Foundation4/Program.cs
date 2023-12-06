class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        Run run = new Run("03 Nov 2022", 30, "Running", 4.8);
        activities.Add(run);
        Bicycle bicycle = new Bicycle("03 Nov 2022", 30, "Bicycling", 9.6);
        activities.Add(bicycle);
        Swim swim = new Swim("03 Nov 2022", 30, "Swimming", 96);
        activities.Add(swim);

        Console.WriteLine();
        foreach (Activity activity in activities)
        {
            activity.GetSummary();
            Console.WriteLine();
        }
    }
}