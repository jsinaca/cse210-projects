class Address {
    protected string _address; 
    protected int _zip;
    protected string _state;

    public Address(string address, int zip, string state) {
        _address = address;
        _zip = zip;
        _state = state;
    }
    public void ChangeAddresss(string newAddress) {
        _address = newAddress;
    }
    public void ChangeZip(int newZipcode) {
        _zip = newZipcode;

    }
    public void ChangeState(string newStete) {
        _state = newStete;
    }
    public virtual string DisplayAddress(){
        return $"Address: {_address}\n Zipcode:{_zip}\n State: {_state}\n";
    }
}