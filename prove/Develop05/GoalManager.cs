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
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"\nCongratulations! You earned {pointsEarned} points!");
            Console.WriteLine($"Your total score is now: {_score}");
            
            // Check for level up
            CheckLevelUp();
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public int GetLevel()
    {
        // Level formula: every 100 points = 1 level
        return (_score / 100) + 1;
    }

    public int GetPointsToNextLevel()
    {
        int currentLevel = GetLevel();
        int pointsForNextLevel = currentLevel * 100;
        return pointsForNextLevel - _score;
    }

    private void CheckLevelUp()
    {
        int newLevel = GetLevel();
        int pointsForCurrentLevel = (newLevel - 1) * 100;
        
        // Check if we just leveled up (score just crossed the threshold)
        if (_score >= pointsForCurrentLevel && _score - pointsForCurrentLevel < 100)
        {
            Console.WriteLine($"\n*** LEVEL UP! You are now Level {newLevel}! ***");
        }
    }

    public void DisplayLevelInfo()
    {
        int level = GetLevel();
        int pointsToNext = GetPointsToNextLevel();
        
        Console.WriteLine($"\n=== Level Information ===");
        Console.WriteLine($"Current Level: {level}");
        Console.WriteLine($"Total Points: {_score}");
        Console.WriteLine($"Points to Next Level: {pointsToNext}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.ToCSV());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');
            string goalType = parts[0];

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), 
                                                        int.Parse(parts[4]), int.Parse(parts[5]));
                goal.SetCurrentCount(int.Parse(parts[6]));
                _goals.Add(goal);
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }

    public int GetGoalCount()
    {
        return _goals.Count;
    }
}