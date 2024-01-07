using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> num = new List<int>();

        while (true) {
            Console.Write("Enter number: ");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber == 0) {
                break;
            }
            else {
                num.Add(userNumber);
            }
        }
        Console.WriteLine($"The sum is: {num.Sum()}");
        Console.WriteLine($"The average is: {num.Average()}");
        Console.WriteLine($"The largest number is: {num.Max()}");
    }
}