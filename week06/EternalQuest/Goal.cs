public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public virtual bool IsComplete() => false;

    public virtual string GetDetailsString()
    {
        return $"[ ] {_name} ({_description})";
    }

    public abstract string GetStringRepresentation();
    public int GetPoints() => _points;
}