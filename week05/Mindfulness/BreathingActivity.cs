

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);

        int halfDuration = _duration / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine("Breathe in...");
            DisplayCountDown(4);
            Console.WriteLine("Breathe out...");
            DisplayCountDown(6);
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }
}