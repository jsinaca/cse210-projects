using System.Globalization;

class Assigment {
    protected string _studentName = "Uknown";
    protected string _topic = "None";

    public Assigment (string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }
}