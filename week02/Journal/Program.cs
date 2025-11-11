using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        int choice = 0;
        while (choice != 5)
        {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        choice = int.Parse(Console.ReadLine());
        
        if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
            }
        else if (choice == 2)
            {
                
            }
        else if (choice == 3)
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

            }
        else if (choice == 4)
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                
            }
        else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
            }
        else
            {
                Console.WriteLine("Sorry, this is not a valid option.");   
            }
        
        }
    }
}