using System;
class Program
{
    static void Main(string[] args)
    {
        while (true) {
            string userChoice = Menu();
            switch (userChoice) {
                case "1":
                    string breathingName = "Breathing";
                    string breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    Breathing breathing = new Breathing(breathingName, breathingDescription);
                    Console.Clear();
                    break;
                case "2": {
                    string reflectionName = "Reflection";
                    string reflectionDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    Reflection reflection = new Reflection(reflectionName, reflectionDescription);
                    break;
                }
                case "3": {
                    string listingName = "Listing";
                    string listingDescription =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    Listing listing = new Listing(listingName, listingDescription);
                    break;
                }
                case "4": {
                    Environment.Exit(0);
                    break;
                }
                default : {
                    Console.WriteLine("This is not a valid answer, try again");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
            }
        }
    }
    static string Menu() {
        Console.WriteLine("Menu Option:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string userInput = Console.ReadLine();
        return userInput;
    }
}