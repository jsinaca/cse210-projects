class ApartamentAddress : Address {
    private string _aptNumber;

    public ApartamentAddress(string address, int zip, string state, string aptNumber) : base (address, zip, state) {
        _aptNumber = aptNumber;
    }
    public void ChangeAptNumber(string newAptNumber) {
        _aptNumber = newAptNumber;
    }
    public override void DisplayAddress() {
        Console.WriteLine($"Address: {_address}\nZipcode: {_zip}\nState: {_state}\nApartament Number: {_aptNumber}");
    }

    public override string GetStrignRepresentation() {
        return $"ApartamentAddress:{_address},{_zip},{_state},{_aptNumber}";
    }
}