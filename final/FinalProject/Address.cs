class Address {
    private string _address; 
    private int _zip;
    private string _state;

    public Address(string address, int zip, string state) {
        _address = address;
        _zip = zip;
        _state = state;
    }
    public void ChangeAddresss() {

    }
    public void ChangeZip() {

    }
    public void ChangeState() {

    }
    public virtual string DisplayAddress(){
        return "";
    }
}