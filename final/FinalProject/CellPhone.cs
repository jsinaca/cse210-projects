class CellPhone : Phone {
    private bool _optMessages;

    public CellPhone(int area, int phone) : base (area, phone){}
    public void OptInForMessages() {

    }
    public void OptOutForMesseges() {

    }
    public bool Promotions() {
        return false;
    }
}