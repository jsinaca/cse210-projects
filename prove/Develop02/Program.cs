using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal _userJournal = new Journal();
        PromptGenearator _prompt = new PromptGenearator();
        Console.WriteLine("Welcome to The Journal Program!");
        while (true) {
            string userChoice = Menu();
            switch (userChoice) {
                case "1":
                    string getDate = GetDate();
                    string promptUser = _prompt.GetRandomPrompt();
                    Console.WriteLine($"{promptUser}");
                    string userAnswer = Console.ReadLine();
                    Entry newEntry = new Entry(getDate, promptUser, userAnswer);
                    _userJournal.AddEntry(newEntry);
                    break;
                case "2": {
                    _userJournal.Display();
                    break;
                }
                case "3": {
                    Console.Write("What is the name of the file? ");
                    string userFile = Console.ReadLine();
                    if (File.Exists($"{Directory.GetCurrentDirectory()}/{userFile}")){
                        _userJournal.LoadFromFile(userFile);
                    }
                    else {
                        Console.WriteLine($"File \"{userFile}\" does not exist in directory");
                    }
                    break;
                }
                case "4": {
                    Console.Write("What is the name of the file? ");
                    string userFile = Console.ReadLine();
                    _userJournal.SaveToFile(userFile);
                    break;
                }
                case "5": {
                    Environment.Exit(0);
                    break;
                }
                default : {
                    Console.WriteLine("This is not a valid answer, try again");
                    break;
                }
            } 
            
        }
    }
    static string Menu() {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string userInput = Console.ReadLine();
        return userInput;
    }
    static string GetDate () {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}