
class Breathing : Activity {
    public Breathing (string name, string description) : base (name, description)  {
        Run();
    }
    public void Run() {
        Welcome();
        DateTime endTime = EndTime(_duration);
        while (DateTime.Now < endTime) {
            Console.WriteLine();
            Console.Write("Breathe in...");
            CountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            CountDown(6);
            Console.WriteLine();
        }
        Ending();
    }
}