// ChecklistGoal.cs
public class ChecklistGoal : Goal
{
    private int _requiredCount;
    private int _currentCount;
    private int _bonusPoints;

    // Constructor
    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints)
        : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        if (_currentCount < _requiredCount)
        {
            _currentCount++;
        }
    }

    public override string GetStatus()
    {
        return _currentCount >= _requiredCount
            ? $"[X] Completed with Bonus {_bonusPoints}!"
            : $"[ ] Completed {_currentCount}/{_requiredCount} times";
    }
}
