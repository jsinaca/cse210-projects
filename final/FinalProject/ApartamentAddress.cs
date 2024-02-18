class ApartamentAddress : Address {
    private string _aptNumber;

    public ApartamentAddress(string address, int zip, string state, string aptNumber) : base (address, zip, state) {
        _aptNumber = aptNumber;
    }
    public void ChangeAptNumber(string newAptNumber) {
        _aptNumber = newAptNumber;
    }
    public override string DisplayAddress() {
        return $"Address: {_address}\n Zipcode:{_zip}\n State: {_state}\n Apartament Number: {_aptNumber}";
    }
}