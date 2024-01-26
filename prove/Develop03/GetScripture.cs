using HtmlAgilityPack;

public class GetScripture : Reference{
    public GetScripture (string book, int chapter, int verse) : base (book, chapter, verse) {}
    public GetScripture (string book, int chapter, int verse, int endVerse) : base (book, chapter, verse, endVerse) {}

    private List<string> _ot = new List<string>() {"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", 
    "1 Samuel", "2 Samuel", "1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", 
    "Psalms", "Proverbs", "Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", 
    "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malach"}; 
    private Dictionary<string, string> _abbreviation = new Dictionary<string, string>() {
        {"Genesis", "gen"}, {"Exodus", "exod"}, {"Leviticus", "lev"}, {"Numbers", "num"}, {"Deuteronomy", "deut"}, {"Joshua", "josh"}, 
        {"Judges", "judg"}, {"Ruth", "ruth"}, {"1 Samuel", "1-sam"}, {"2 Samuel", "2-sam"}, {"1 Kings", "1-kgs"}, {"2 Kings", "2-kgs"}, 
        {"1 Chronicles", "1-chr"}, {"2 Chronicles", "2-chr"}, {"Ezra", "ezra"}, {"Nehemiah", "neh"},{"Esther", "esth"},{"Job", "job"},
        {"Psalms", "ps"},{"Proverbs", "prov"}, {"Ecclesiastes", "eccles"}, {"Song of Solomon", "song"},{"Isaiah", "isa"}, {"Jeremiah", "jer"}, 
        {"Lamentations", "lam"}, {"Ezekiel", "ezek"}, {"Daniel", "dan"}, {"Hosea", "hosea"}, {"Joel", "joel"}, {"Amos", "amos"}, 
        {"Obadiah", "obad"}, {"Jonah", "jonah"}, {"Micah", "micah"}, {"Nahum", "nahum"}, {"Habakkuk", "hab"}, {"Zephaniah", "zeph"},
        {"Haggai", "hag"}, {"Zechariah", "zech"}, {"Malach", "mal"}
    };
    public string GetVersicles() {
        string final = "";
        string book = DetermineBook(_book);
        string inBook = DetermineInBook(_book);

        if (_book != "no valid" && inBook != "no book found") {
            if (_endVerse == 0) {
                final = GetVerse(book, inBook, _verse);
            }
            else {
                for (int index=_verse; index<=_endVerse; index++) {
                    final += GetVerse(book, inBook, index);
                }
            }
        }
        else {
            final = "Not found";
        }
        return final;
    }
    private string DetermineBook(string book) {
        if (_ot.Contains(book)) {
            return "ot";
        }
        else {
            return "no valid";
        }
    }
    private string DetermineInBook(string book) {
        if (_abbreviation.ContainsKey(book)) {
            return _abbreviation[book];
        }
        else {
            return "no book found";
        }
    }
    private string GetVerse(string book, string inBook, int verse) {
        string output = "";
        var web = new HtmlWeb();
        var document = web.Load($"https://www.churchofjesuschrist.org/study/scriptures/{book}/{inBook}/{_chapter}?lang=eng");
        var productHTMLElements = document.DocumentNode.QuerySelectorAll($".body-block p #p{verse}");

        for (int i=0; i< productHTMLElements.Count; i ++) {
            for (int k=1; k< productHTMLElements[i].ChildNodes.Count(); k++) {
                if (productHTMLElements[i].ChildNodes[k].Name == "a") {
                    output += productHTMLElements[i].ChildNodes[k].LastChild.InnerText;
                }
                else {
                    output += productHTMLElements[i].ChildNodes[k].InnerText;
                }
            }
            output += " ";
        }
        return output;
    }
} 