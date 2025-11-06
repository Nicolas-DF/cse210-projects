using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 100);

        Console.WriteLine("Magic Number Game!");
        bool done = false;

        do
        {
            Console.Write("Whats is your guess? ");
            string guess = Console.ReadLine();
            int number = int.Parse(guess);

            if (number > MagicNumber)
            {
                Console.WriteLine("Lower.");
            }
            else if (number < MagicNumber)
            {
                Console.WriteLine("Higher.");
            }
            else
            {
                done = true;
            }

        } while (done == false);

        Console.WriteLine("You guessed it!!!");


    }
}