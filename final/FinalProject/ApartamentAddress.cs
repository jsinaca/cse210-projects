class ApartamentAddress : Address {
    private string _aptNumber;

    public ApartamentAddress(string address, int zip, string state, string aptNumber) : base (address, zip, state) {
        _aptNumber = aptNumber;
    }
    public void ChangeAptNumber() {

    }
    public override string DisplayAddress() {
        return "";
    }
}