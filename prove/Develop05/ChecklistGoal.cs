using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            return _points + _bonusPoints;
        }
        
        return _points;
    }

    public override string GetStatus()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
    }

    public override string ToCSV()
    {
        return $"ChecklistGoal,{_name},{_description},{_points},{_targetCount},{_bonusPoints},{_currentCount},{_isComplete}";
    }

    public void SetCurrentCount(int count)
    {
        _currentCount = count;
    }
}