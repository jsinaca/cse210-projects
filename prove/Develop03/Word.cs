class Word {
    private string _text;
    private bool _isHidden = false;

    public Word (string text) {
        _text = text;
    }
    public void Hide() {
        _isHidden = true;
    }
    public void Show() {
        _isHidden = false;
    }
    public bool IsHidden() {
        return _isHidden;
    }
    public string GetDisplayText() {
        if (_isHidden) {
            string temp = "";
            foreach (char i in _text) {
                temp += "_";
            }
            return temp;
        }
        else {
            return _text;
        }
    }
}