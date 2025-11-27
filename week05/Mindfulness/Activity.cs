

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(4);
    }
    public void ShowSpinner(int seconds)
    {
        char[] spinnerChars = { '|', '/', '—', '\\' };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public void DisplayCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds--;
        }
    }
}