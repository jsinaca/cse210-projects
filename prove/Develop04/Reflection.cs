class Reflection : Activity {
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>{ 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public Reflection (string name, string description) : base (name, description)  {
        Run();
    }
    public void Run(){
        Welcome();
        DisplayPrompt();
        Console.Write("You may begin in: ");
        CountDown(4);
        Console.Clear();
        DisplayQuestion();
        Ending();
    }
    private string GetRandomPrompt() {
        Random prompt = new Random();
        int random = prompt.Next(0, _prompts.Count - 1);
        return _prompts[random];
    }
    private string GetRandomQuestion() {
        Random question = new Random();
        int random = question.Next(0, _questions.Count - 1);
        return _questions[random];
    }
    private void DisplayPrompt() {
        Console.WriteLine("Consider the folloing prompt:\n");
        Console.WriteLine($"--{GetRandomPrompt()}--\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
    }
    private void DisplayQuestion() {
        DateTime endTime = EndTime(_duration);
        List<int> questionDisplayed = new List<int>(); 

        while (DateTime.Now < endTime) {
            string question = GetRandomQuestion(); 
            Console.Write($"{question}");
            Spinner(10);
            // questionDisplayed.Add(_questions.FindIndex(a => a.Contains(question)));
            _questions.Remove(question);
            Console.WriteLine();
        }
    }

}