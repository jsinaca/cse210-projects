using System.Security;

class WritingAssigment : Assigment {
    private string _title;
    public WritingAssigment (string studentName, string topic, string title) : base (studentName, topic) {
        _title = title;
    }
    public string GetWrtitingInformation() {
        return $"{_title}";
    }
}