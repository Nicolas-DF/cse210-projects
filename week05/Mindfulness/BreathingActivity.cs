

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        int cycles = _duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in...");
            DisplayCountDown(4);
            Console.Write("\nBreathe out...");
            DisplayCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }
}