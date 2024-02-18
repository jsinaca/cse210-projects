class Payment {
    public int _number;
    public string _nameHolder;
    public  Address _address;
    // public double _amount;

    public Payment(int number, string holder, Address address) {
        _number = number;
        _nameHolder = holder;
        _address = address;
        // _amount = amount;
    }
    public void ChangeNumber(int newNumber) {
        _number = newNumber;
    }
    public void ChangeName(string newName) {
        _nameHolder = newName;
    }
    public void ChangeAddress(Address newAddress) {
        _address = newAddress;
    }
    // public void ChangeAmount(double newAmount) {
    //     _amount = newAmount;
    // }
    // public void DisplayPayment() {

    // }
}