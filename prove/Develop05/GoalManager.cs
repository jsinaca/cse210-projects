using System.Diagnostics;

class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager () {}
    public void Start() {
        while (true) {
            DisplayPlayerInfo();
            string userInput = Menu();
            switch (userInput) {
                case "1" : {
                    CreateGoal();
                    break;
                }
                case "2" : {
                    ListGoalDetails();
                    break;
                }
                case "3" : {
                    SaveGoals();
                    break;
                }
                case "4" : {
                    LoadGoals();
                    break;
                }
                case "5" : {
                    RecordEvent();
                    break;
                }
                case "6" : {
                    Environment.Exit(0);
                    break;
                }
                default : {
                    Console.WriteLine($"{userInput} is not an option");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
        }
    }
    private void DisplayPlayerInfo() {
        Console.WriteLine($"You have {_score} points\n");
    }
    private void ListGoalNames() {
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals) {
            Console.WriteLine($"{count}. {goal.GoalName()}");
            count ++;
        }
    }
    private void ListGoalDetails() {
        Console.Clear();
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals) {
            Console.WriteLine($"{count}. {goal.GetDetailsString()}");
            count++;
        }
    }
    private void CreateGoal() {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        switch (userInput) {
            case "1" : {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
                Console.Clear();
                break;
            }
            case "2" : {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                Console.Clear();
                break;
            }
            case "3" : {
                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                string points = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int amount = int.Parse(Console.ReadLine());
                Console.Write("What is the bounus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, amount, bonus);
                _goals.Add(checklistGoal);
                Console.Clear();
                break;
            }
            default : {
                Console.WriteLine($"{userInput} is not an option");
                Thread.Sleep(3000);
                break;
            }
        }
    }
    private void RecordEvent () {
        Console.Clear();
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int accomplishGoal = int.Parse(Console.ReadLine());
        if (accomplishGoal >= _goals.Count) {
            Console.WriteLine($"{accomplishGoal} is not in the list, please try again");
            Thread.Sleep(3000);
        }
        else {
            Goal tempGoal = _goals[accomplishGoal-1];
            if (tempGoal.GetType().ToString() == "SimpleGoal" || tempGoal.GetType().ToString() == "ChecklistGoal" ) {
                if (!tempGoal.IsComplete()) {
                    tempGoal.RecordEvent();
                    _score += tempGoal.PointsEarn();
                }
                else {
                    Console.WriteLine("This goal has been compleated");
                    Thread.Sleep(3000);
                }
            }
            else if (tempGoal.GetType().ToString() == "EternalGoal") {
                tempGoal.RecordEvent();
                _score += tempGoal.PointsEarn();
            }
        }
        Console.Clear();
    }
    private void SaveGoals() {
        Console.Write("What is the name of the file? ");
        string userFile = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(userFile)) {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals) {
                outputFile.WriteLine($"{goal.GetType()}: {goal.GetStrignRepresentation()}");
            }   
        }
        Console.Clear();
    }
    private void LoadGoals() {
        Console.Write("What is the name of the file? ");
        string userFile = Console.ReadLine();
        if (File.Exists($"{Directory.GetCurrentDirectory()}/{userFile}")) {
            List<string> lines = new List<string>(File.ReadAllLines(userFile));
            _score = int.Parse(lines[0]);
            lines.RemoveAt(0);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split(":");
                if (parts[0] == "SimpleGoal") {
                    string[] arg = parts[1].Split(",");
                    SimpleGoal simpleGoal = new SimpleGoal(arg[0], arg[1], arg[2], bool.Parse(arg[3]));
                    _goals.Add(simpleGoal);
                }
                else if (parts[0] == "EternalGoal") {
                    string[] arg = parts[1].Split(",");
                    EternalGoal simpleGoal = new EternalGoal(arg[0], arg[1], arg[2]);
                    _goals.Add(simpleGoal);
                }
                else {
                    string[] arg = parts[1].Split(",");
                    ChecklistGoal simpleGoal = new ChecklistGoal(arg[0], arg[1], arg[2], int.Parse(arg[3]), int.Parse(arg[4]), int.Parse(arg[5]));
                    _goals.Add(simpleGoal);
                }
            }
        }
        else {
            Console.WriteLine($"{userFile} does not exist in directory");
            Thread.Sleep(3000);
        }
        Console.Clear();
    }
    private string Menu() {
        Console.WriteLine("Menu options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        string userInput = Console.ReadLine();
        return userInput;
    }
}