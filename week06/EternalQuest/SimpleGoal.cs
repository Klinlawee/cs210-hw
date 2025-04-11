// SimpleGoal.cs
public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    // Constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStatus()
    {
        return _isComplete ? "[X] Completed" : "[ ] Not Completed";
    }
}
