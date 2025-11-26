using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        WrittingAssignment writtingAssignment = new WrittingAssignment("The Causes of World War II", "Mary Waters", "European History");
        Console.WriteLine(writtingAssignment.GetSummary());
        Console.WriteLine(writtingAssignment.GetWrittingInfo());
    }
}