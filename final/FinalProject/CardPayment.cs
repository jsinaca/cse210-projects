class CardPayment : Payment {
    private int _cvvCode;

    public CardPayment(int number, string holder, Address address, double amount, int cvv) : base (number, holder, address, amount) {

    }
    public void ChangeCVV() {
        
    }
}