using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.Write("What is your grade percentage?");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        else
        {
            Console.Write("Invalid input");
            letter = "F";
        }

        if (grade >= 90)
        {
            Console.WriteLine($"Congratulations you pass this class with an {letter}");
            
        }
        else if (grade >= 70) {
            Console.WriteLine($"Congratulations you pass this class with a {letter}");
        }

        else if (grade < 70)
        {
            Console.WriteLine($"I'm sorry you did't pass this class, keep tring next semester");
        }
    }
}