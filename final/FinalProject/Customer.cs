class Customer {
    private string _firstName;
    private string _lastName;
    private  List<Address> _address;
    private DateTime _dob; 
    private List<Payment> _payment = new List<Payment>();
    private List<Phone> _phone = new List<Phone>(); 
    private int _id;

    public Customer(string name, string last, Address address, DateTime dob) {
        _firstName = name;
        _lastName = last;

    }
    public void DisplayCustomerInfo() {

    }
    public  void AddAddress() {

    }
    public void AddDOB() {

    } 
    public void AddPayment() {

    }
    public void AddPhone() {

    }
}