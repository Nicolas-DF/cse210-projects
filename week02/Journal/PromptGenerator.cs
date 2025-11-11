using System;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "How did you see the hand of the Lord in your life today?",
        "What are you grateful for today?",
        "What made you smile today?",
        "Who did you serve today and how?",
        "What is something you would have done differently today?"

    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}