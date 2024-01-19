class Scripture {
    Reference _reference = new Reference("Proverbs", 3, 5);
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        string[] temp = text.Split();
        foreach (string i in temp) {
            Word tempWord = new Word(i);
            _words.Add(tempWord);
        }
    }
    public void HideRandomWords() {
        int count = 0;
        foreach (Word word in _words){
            if (count == 3 || IsCompleteHidden()) {
                break;
            }
            else {
                List<int> listToChose = WordsNoHidden();
                while (true) {
                    Random status = new Random();
                    int random = status.Next(0,listToChose.Count-1);
                    if (!_words[listToChose[random]].IsHidden()) {
                        _words[listToChose[random]].Hide();
                        count += 1;
                        break;
                    }
                }
            }
        }
    }
    public string GetDisplayText() {
        Console.WriteLine($"{_reference.GetDisplay()}");
        string outputText = "";
        foreach (Word word in _words){
            outputText += $"{word.GetDisplayText()} ";
        }
        return outputText;
    }
    public bool IsCompleteHidden() {
        bool compleate = false;
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                compleate = false;
                break;
            }
            else {
                compleate = true;
            }
        }
        return compleate;
    }
    private List<int> WordsNoHidden() {
        List<int> listToChose = new List<int>();
        for (int i=0; i<=_words.Count-1; i++  ) {
            if (!_words[i].IsHidden()) {
                listToChose.Add(i);
            }
        }   
        return listToChose;
    }
}
