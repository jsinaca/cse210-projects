class DateOfBirth {
    private string _month;
    private string _day;
    private string _year;

    public DateOfBirth (string month, string day, string year) {
        _month = month;
        _day = day;
        _year = year;
    }
    public void ChangeMonth(string newMonth) {
        _month = newMonth;
    }
    public void ChangeDay(string newDay) {
        _day = newDay;
    }
    public void ChangeYear(string newYear) {
        _year = newYear;
    }
    public void DisplayDOB() {
        Console.WriteLine($"Day of Birth: {_month}/{_day}/{_year}");
    }
    public string GetStrignRepresentation() {
        return $"{_month}/{_day}/{_year}";
    }
}