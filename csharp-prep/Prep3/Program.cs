using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomGen = new Random();
        int num = randomGen.Next(1,101); 
        int guessCount = 0;
        // Console.Write("  What is the magic number? ");
        // int guessNumber = int.Parse(Console.ReadLine());
        while (true) {
            Console.Write("  What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());
            if (userGuess < num) {
                Console.WriteLine("Higher");
                guessCount += 1;
            }
            else if (userGuess > num) {
                Console.WriteLine("Lower");
                guessCount += 1;
            }
            else {
                guessCount += 1;
                Console.WriteLine("You gess it!");
                Console.WriteLine($"You guess it in your {guessCount} try");
                break;
            }
        }
        ;
        
    }
}