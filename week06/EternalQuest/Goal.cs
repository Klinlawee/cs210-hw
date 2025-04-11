// Goal.cs
public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Properties
    public string GetName() => _name;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // Abstract method for progress tracking
    public abstract void RecordEvent();
    public abstract string GetStatus();
}
