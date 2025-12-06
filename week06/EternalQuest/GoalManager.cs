using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                SaveGoals(filename, _score, _goals);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                LoadGoals(filename);
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        

        Goal newGoal;
        if (choice == 1)
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (choice == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else
        {
            Console.Write("Enter target count: ");
            int targetCount = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new CheckListGoal(name, description, points, targetCount, bonus);
        }
        _goals.Add(newGoal);

    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetName()}");
        }
        Console.Write("Which goal did you acomplish? ");
        int answer = int.Parse(Console.ReadLine()) - 1;
        int points = _goals[answer].GetPoints();
        _score += points;
        _goals[answer].RecordEvent();

        if (_goals[answer] is CheckListGoal checklist && checklist.IsComplete())
        {
            _score += checklist.GetBonus();
            Console.WriteLine($"⭐⭐⭐ Congrats!!! You have earned a bonus of {checklist.GetBonus()} + normal {points} points!!! ⭐⭐⭐");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        Console.WriteLine($"You have now {_score} points.");
    }
    public void SaveGoals(string filename, int score, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string goalType = parts[0];

            Goal goal;
            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                goal = new SimpleGoal(name, description, points);
                if (isComplete)
                {
                    goal.RecordEvent();
                }
            }
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                goal = new EternalGoal(name, description, points);
            }
            else if (goalType == "CheckListGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                goal = new CheckListGoal(name, description, points, target, bonus);
                for (int e = 0; e < amountCompleted; e++)
                {
                    goal.RecordEvent();
                }
            }
            else
            {
                throw new Exception("Unknown goal type in file: " + goalType);
            }
            _goals.Add(goal);
        }
    }
}