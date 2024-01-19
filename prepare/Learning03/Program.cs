using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction _test = new Fraction(); 
        Fraction _test2 = new Fraction(5); 
        // Fraction _test3 = new Fraction(6, 7); 
        Fraction _test4 = new Fraction(3, 4); 
        Fraction _test5 = new Fraction(1, 3); 

        Console.WriteLine($"{_test4.GetFractionString()}");
        Console.WriteLine($"{_test4.GetDecimalValue()}");
        Console.WriteLine($"{_test.GetFractionString()}");
        Console.WriteLine($"{_test.GetDecimalValue()}");
        Console.WriteLine($"{_test2.GetFractionString()}");
        Console.WriteLine($"{_test2.GetDecimalValue()}");
        Console.WriteLine($"{_test5.GetFractionString()}");
        Console.WriteLine($"{_test5.GetDecimalValue()}");
    }
}