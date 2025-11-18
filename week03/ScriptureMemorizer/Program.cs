using System;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.");

        while (true)
        {
            Console.Clear();
            reference.GetDisplayText();
            Console.Write(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            string response = Console.ReadLine();

            if (response == "quit")
            {
                break;
            }

            scripture.HideRandomNumbers(3);
        }
    }
}