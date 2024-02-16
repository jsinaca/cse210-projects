class ElectronickCheck : Payment {
    private int _routingNumber;
    private int _accoiuntNumber;

    public ElectronickCheck(int number, string holder, Address address, double amount, int routing, int  account) : base (number, holder, address, amount) {
        _routingNumber = routing;
        _accoiuntNumber = account;
    }
    public void ChangeRouting() {

    }
    public void ChangeAccountNumber() {

    }
}