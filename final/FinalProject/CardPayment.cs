class CardPayment : Payment {
    private int _cvvCode;

    public CardPayment(int number, string holder, Address address, int cvv) : base (number, holder, address) {

    }
    public void ChangeCVV(int newCVV) {
        _cvvCode = newCVV;
    }
}