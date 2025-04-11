// EternalGoal.cs
public class EternalGoal : Goal
{
    private int _timesRecorded = 0;

    // Constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        _timesRecorded++;
    }

    public override string GetStatus()
    {
        return $"Completed {_timesRecorded} times";
    }
}
