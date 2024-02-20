class HomeAddress : Address {
    public HomeAddress(string address, int zip, string state) : base (address, zip, state) {}

    public override string GetStrignRepresentation() {
        return $"HomeAddress:{_address},{_zip},{_state}";
    }
}