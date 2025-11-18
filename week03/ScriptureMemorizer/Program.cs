using System;
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.");

        //Asking to user the "mode", that makes the memorizing process easier or harder.
        Console.Write("Do you want the easy (E) mode or spicy mode (S)? ");
        string mode = Console.ReadLine();
        

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

            // Propositally making the answer to be easy or not. The spicy mode goes on if the user doesn't ask for the easy mode
            if (mode.ToLower() == "e" || mode.ToLower() == "easy")
            {
                scripture.HideRandomNumbers(3);
            }
            else
            {
                scripture.HideRandomNumbers(6);
            }
        }
    }
}