class Listing : Activity {
    private int _count;
    private List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    public Listing (string name, string description) : base (name, description)  {
        Run();
    }
    public void Run() {
        Welcome();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may beging in: ");
        CountDown(6);
        Console.WriteLine();
        List<string> userList = new List<string>();
        GetListFromUser(userList);
        Console.WriteLine($"You listed {_count} items");
        Ending();
        SaveFile(userList, prompt);
    } 
    public string GetRandomPrompt() {
        Random prompt = new Random();
        int random = prompt.Next(0, _prompts.Count - 1);
        return _prompts[random];
    }
    public List<string> GetListFromUser(List<string> list) {
        DateTime endTime = EndTime(_duration);
        while (DateTime.Now < endTime) {
            Console.Write(">");
            list.Add(Console.ReadLine());
            _count ++;
        }
        return _prompts;
    }
    private void SaveFile(List<string> list, string prompt) {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        using (StreamWriter outputFile = File.AppendText("myFile.txt"))
        {
        outputFile.WriteLine($"Date: {dateText}");
        outputFile.WriteLine($"Prompt: {prompt}");
        foreach (string i in list) {
                outputFile.WriteLine($"{i}");
            }   
        }
    }
}