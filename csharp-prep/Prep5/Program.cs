using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), PromptUserNumber());
    }
    static void DisplayWelcome () {
        // DisplayWelcome - Displays the message, "Welcome to the Program!"
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName () {
        // PromptUserName - Asks for and returns the user's name (as a string)
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber () {
        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        Console.Write("Please enter your favorite number:");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;

    } 
    static int SquareNumber (int num) {
        // SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        return num*num;
    }
    static void DisplayResult (string userName, int numSqr) {
        // DisplayResult - Accepts the user's name and the squared number and displays them.
        Console.WriteLine($"Brother {userName}, the square of your number is {SquareNumber(numSqr)}");
    }

}