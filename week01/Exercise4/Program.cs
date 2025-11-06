using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;

        // Getting user input and adding into the list
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Getting the sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Getting the average
        int count = numbers.Count;
        float average = sum / count;
        Console.WriteLine($"The average is: {average}");

        // Getting the largest one
        int largest = 0;
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}