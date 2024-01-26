using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Scripture memorizer");
        Console.WriteLine("What book from the old testament you want? ");
        string book = Console.ReadLine();
        Console.WriteLine($"What chapter from {book} you want? ");
        int chapter = int.Parse(Console.ReadLine());
        Console.WriteLine($"What first verse from {book} {chapter} you want? (Initial verse)? ");
        int fistVerse = int.Parse(Console.ReadLine());
        Console.WriteLine($"What end verse from {book} {chapter} you want? (End verse or type 0 to no select one)? ");
        int lastVerse = int.Parse(Console.ReadLine());

        Reference _reference = new Reference(book, chapter, fistVerse, lastVerse);
        GetScripture _verse = new GetScripture(book, chapter, fistVerse, lastVerse);
        string _txt = _verse.GetVersicles();
        if (_txt == "Not found") {
            Console.WriteLine("Book, chapter, versicle not found.");
            Console.WriteLine("Please, run program again");
        }
        else {
            Scripture script = new Scripture(_reference, _txt);
            while (true) {
                Console.Clear();
                Console.WriteLine(script.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type \"quit\" to finish");
                string userInput = Console.ReadLine();
                if (userInput == "quit") {
                    break;
                }
                else if (userInput == "") {
                    if (!script.IsCompleteHidden()) {
                        script.HideRandomWords();
                    }
                    else {
                        break;
                    }
                }
                else {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}