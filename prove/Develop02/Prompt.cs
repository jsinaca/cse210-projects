
class PromptGenearator
{
    public List<string> _prompts = new List<string> {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "If I had one thing I could do over today, what would it be? "
        };

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        return $"{_prompts[randomPrompt.Next(0, _prompts.Count-1)]}";
    }
}