class ECheck : Payment {
    private int _routingNumber;
    private int _accountNumber;

    public ECheck(int checkNumber, string holder, Address address, int routing, int  account) : base (checkNumber, holder, address) {
        _routingNumber = routing;
        _accountNumber = account;
    }
    public void ChangeRouting(int newRoutingNumber) {
        _routingNumber = newRoutingNumber;
    }
    public void ChangeAccountNumber(int newAccountNumber) {
        _accountNumber = newAccountNumber;
    }
}