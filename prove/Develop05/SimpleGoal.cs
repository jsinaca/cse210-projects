class SimpleGoal : Goal {
    private bool _isComplete = false;
    public SimpleGoal (string name, string description, string points, bool compleated = false) : base (name, description, points) {
        _isComplete = compleated;
    }
    public override void RecordEvent(){
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStrignRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}, {_isComplete}";
    }
}