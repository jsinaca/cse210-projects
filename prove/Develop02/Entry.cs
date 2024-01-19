

using CsvHelper;

class Entry
{
    Entry () {}
    public Entry (string date, string promptText, string entryText) {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }
    public string _date {get; set;}
    public string _promptText {get; set;}
    public string _entryText {get; set;}
    public void Display()
    {
        Console.WriteLine($"Date:{_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine();
    }
}