public class Reference {
    protected string _book;
    protected int _chapter;
    protected int _verse;
    protected int _endVerse = 0;
    public Reference (string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference (string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    public string GetDisplay() {
        if (_endVerse == 0) {
            return $"{_book} {_chapter}: {_verse}";
        }
        else {
            return $"{_book} {_chapter}: {_verse} - {_endVerse}";
        }
    }
}
