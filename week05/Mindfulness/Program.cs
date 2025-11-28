using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();

        Console.WriteLine("Menu Options:");
        Console.WriteLine("     1. Start breathing activity");
        Console.WriteLine("     2. Start reflection activity");
        Console.WriteLine("     3. Start listing activity");
        Console.WriteLine("     4. Quit");
        Console.Write("Select a choice from the menu: ");

        string choice = Console.ReadLine();
        while (choice != "4")
        {
            if (choice == "1")
            {
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                reflectionActivity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
        }
    }
}