public class ChecklistGoal : Goal {
    private int _amountComplete=0;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, string points, int amount, int bonus) : base (name, description, points) {
        _target = amount;
        _bonus = bonus;
    }
    public ChecklistGoal (string name, string description, string points, int amount, int target, int bonus) : base (name, description, points) {
        _amountComplete = amount;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountComplete < _target) {
            _amountComplete ++;
        }
    }
    public override bool IsComplete()
    {
        if (_amountComplete == _target) {
            return true;
        }
        else {
            return false;
        }
    }
    public override string GetStrignRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}, {_amountComplete}, {_target}, {_bonus}";
    }
    public override string GetDetailsString()
    {
        string final;
        string complete = " ";
        if (IsComplete()) {
            complete = "X";
        }
        final = $"[{complete}] {_shortName} ({_description}) -- Currently compleated: {_amountComplete}/{_target}";
        return final;
    }
    public override int PointsEarn() {
        int totalPoints = int.Parse(_points);
        if (IsComplete()) {
                totalPoints += _bonus;
        }
        return totalPoints;
    }
}