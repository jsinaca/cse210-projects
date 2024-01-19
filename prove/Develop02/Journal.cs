using CsvHelper;
using System.Globalization;
class Journal
{
    public List<Entry> _entires = new List<Entry>(); 
    public void AddEntry(Entry newEntry)
    {
        _entires.Add(newEntry);
    }
    public void Display () {
        foreach (Entry entry in _entires) {
            entry.Display();
        }
    }
    public void SaveToFile (string file) {
        using (StreamWriter outputFile = new StreamWriter(file))
        if (file.Contains("csv")) {
            using (var csv = new CsvWriter(outputFile, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(_entires);
            }
        }
        else {
            foreach (Entry entry in _entires) {
                outputFile.WriteLine($"{entry._date}");
                outputFile.WriteLine($"{entry._promptText}");
                outputFile.WriteLine($"{entry._entryText}");
            }   
        }
    }
    public void LoadFromFile (string file) {
        if (file.Contains("csv")) {
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read()) {
                    var record = csv.Context.Parser.RawRecord.Split(",");
                    Entry temp = new Entry(record[0],record[1], record[2]);
                    _entires.Add(temp);
                }
            }
        }
        else {
            string[] lines = File.ReadAllLines(file);
            int dateIndex = 0;
            int promptIndex = 1;
            int textIndex = 2;

            for (int i= 0; i < lines.Length; i+=3)
            {   
                Entry newEntry = new Entry(lines[dateIndex], lines[promptIndex], lines[textIndex]);
                AddEntry(newEntry);
                dateIndex += 3;
                promptIndex += 3;
                textIndex += 3;                
            }
        }
    }
}