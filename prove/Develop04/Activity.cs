class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity (string name, string description) {
        _name = name;
        _description = description;
    }
    protected void Welcome() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        GetReady();
    }
    protected void Spinner(int seconds=8) {
        DateTime endTime = EndTime(seconds);
        string[] waiting = {"-", "\\", "|", "/"};
        int index = 0;
        while (DateTime.Now < endTime) {
            Console.Write($"{waiting[index]}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            index++;
            if (index >= waiting.Length) {
                index = 0;
            }
        }
    } 
    protected void CountDown(int seconds) {
        DateTime endTime = EndTime(seconds);
        while (DateTime.Now < endTime) {
            Console.Write($"{seconds--}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    } 
    protected void Ending() {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have compleated another {_duration} seconds of the {_name} Activity.");
        Spinner();
        Console.Clear();
    }
    protected DateTime EndTime(int seconds) {
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);
        return endTime;
    }
    private void GetReady() {
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner();
        Console.Write("\b \b");
        Console.WriteLine();
        Console.Clear();
    }
}