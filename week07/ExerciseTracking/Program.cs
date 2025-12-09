using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Set culture to invariant to ensure consistent number formatting
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;


        List<Activity> activities = new List<Activity>();

        Activity running = new Running("09 Dec 2025", 30, 4800);
        activities.Add(running);
        Activity cycling = new Cycling("08 Dec 2025", 45, 15);
        activities.Add(cycling);
        Activity swimming = new Swimming("07 Dec 2025", 60, 30);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}