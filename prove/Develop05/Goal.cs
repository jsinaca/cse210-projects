public abstract class Goal {
    protected string _shortName;
    protected string _description;
    protected string _points;
    public Goal (string name, string description, string points) {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString(){
        string complete = " ";
        if (IsComplete()) {
            complete = "X";
        }
        return $"[{complete}] {_shortName}, {_description}";
    }
    public abstract string GetStrignRepresentation();
    public string GoalName(){
        return $"{_shortName}";
    }
    public virtual int PointsEarn() {
        return int.Parse(_points);
    }

}