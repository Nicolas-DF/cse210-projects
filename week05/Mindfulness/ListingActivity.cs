

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are the people that you have helped this week?",
        "When have you felt the Holy Ghost in your life?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        DisplayCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                _count++;
            }
        }

        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();
        ShowSpinner(3);
    }
}