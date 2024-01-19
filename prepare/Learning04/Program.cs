using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");
        Assigment _assigment = new Assigment("Josue", "Math");
        Console.WriteLine(_assigment.GetSummary());
        MathAssigment _math = new MathAssigment("Josue", "Math", "7.3", "8-19");
        Console.WriteLine(_math.GetSummary());
        Console.WriteLine(_math.GetHomeworkList());
        WritingAssigment _writing = new WritingAssigment("Josue", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(_writing.GetSummary());
        Console.WriteLine(_writing.GetWrtitingInformation());
    }
}