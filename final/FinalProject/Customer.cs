class Customer {
    private string _firstName;
    private string _lastName;
    // private  List<Address> _address = new List<Address>();
    private  Address _address;
    private DateOfBirth _dob; 
    // private Payment _paymentInformation;
    private List<Phone> _phone = new List<Phone>(); 
    // private int _id;

    public Customer(string name, string last, Address address, DateOfBirth dob) {
        _firstName = name;
        _lastName = last;
        // _address.Add(address);
        _dob = dob;

    }
    public void DisplayCustomerInfo() {

    }
    public void AddAddress(Address address) {
        _address = address;
    }
    // public void ModifyAddress(int number) {
    public void ModifyAddress() {
        Console.WriteLine("What would you like to modify?");
        Console.WriteLine("1. Address");
        Console.WriteLine("2. Zipcode");
        Console.WriteLine("3. State");
        Console.Write("Select an option: ");
        string userInput = Console.ReadLine();
        switch (userInput) {
            case "1" : {
                Console.Write("What is the new address? ");
                string newAddress = Console.ReadLine();
                _address.ChangeAddresss(newAddress);
                break;
            }
            case "2" : {
                Console.Write("What is the new zipcode? ");
                int newZipcode = int.Parse(Console.ReadLine());
                _address.ChangeZip(newZipcode);
                break;
            }
            case "3" : {
                Console.Write("What is the new State? ");
                string newState = Console.ReadLine();
                _address.ChangeState(newState);
                break;
            }
            default : {
                Console.WriteLine("Invalid input");
                break;
            }
        }
    }
    public void AddDOB() {
        

    } 
    public void ChangeDOB() {
        Console.Write("What would you like to modify from the user? ");
        Console.Write("1. Month");
        Console.Write("2. Day");
        Console.Write("3. Year");
        string useroption = Console.ReadLine();
        switch (useroption) {
            case "1" : {
                Console.Write("What it the new month (MM)?");
                string newMonth = Console.ReadLine();
                _dob.ChangeMonth(newMonth);
                break;
            }
            case "2" : {
                Console.Write("What it the new day (DD)?");
                string newDay = Console.ReadLine();
                _dob.ChangeDay(newDay);
                break;
            }
            case "3" : {
                Console.Write("What it the new year (YYYY)?");
                string newYear = Console.ReadLine();
                _dob.ChangeDay(newYear);
                break;
            }
            default : {
                Console.Write("Invalid input");
                break;
            }
        }
    } 

    // public void AddPaymentInformation() {
    //     Console.WriteLine("Would you like to pay with:");
    //     Console.WriteLine("1. Debit/Credit card)");
    //     Console.WriteLine("2. Electronic check");
    //     Console.Write("Select and option: ");
    //     string userOption = Console.ReadLine();
    //     switch (userOption) {
    //         case "1" : {
    //             Console.WriteLine("What is the debit/credit card number");
    //             int number = int.Parse(Console.ReadLine());
    //             Console.WriteLine("Are you the main holder?");
    //             string mainHolder = Console.ReadLine();
    //             string holder;
    //             Address address; 
    //             if (mainHolder != "yes") {
    //                 Console.Write("What is the first and last name of the main holder of the card?");
    //                 holder = Console.ReadLine();
    //             }
    //             else {
    //                 holder = _firstName + _lastName;
    //             }
    //             Console.Write("Is the billing address the same we have in records ?");
    //             string userAddress = Console.ReadLine();
    //             if (userAddress != "yes") {
    //                 Console.Write("What is your address? ");
    //                 string address1 = Console.ReadLine();
    //                 Console.Write("What is your zipcode? ");
    //                 int zip = int.Parse(Console.ReadLine());
    //                 Console.Write("What is your state? ");
    //                 string state = Console.ReadLine();
    //                 Console.Write("Is that an apartament? ");
    //                 string apt = Console.ReadLine();
    //                 if (apt != "yes") {
    //                     address = new HomeAddress(address1,zip, state);
    //                 }
    //                 else {
    //                     Console.Write("What is your apartament number? ");
    //                     string tempApt =Console.ReadLine();
    //                     address = new ApartamentAddress(address1,zip, state, tempApt);
    //                 }
    //                     Console.Write("What is your apartament number? ");
    //                     int cvv = int.Parse(Console.ReadLine());
    //                 _paymentInformation = new CardPayment(number,holder,address, cvv);
    //             }
    //             else {
    //                 Console.Write("What is your apartament number? ");
    //                 int cvv = int.Parse(Console.ReadLine());
    //                 _paymentInformation = new CardPayment(number,holder,_address, cvv);
    //             }
    //             break;
    //         }
    //         case "2" : {
                
    //             _paymentInformation = new Payment();
    //             break;
    //         }
    //         default : {
    //             Console.WriteLine("Invalid inpt");
    //             break;
    //         }
    //     }
    // }
    public void AddPhone() {

    }
    public string GetName() {
        return _firstName;
    }
    public string GetLastName() {
        return _lastName;
    }

    public void ChangeFistName(string newName) {
        _firstName = newName;
    }
    public void ChangeLastName(string newLastName) {
        _lastName = newLastName;
    }
    // public void DisplayAddresses() {
    //     Console.WriteLine("The following addresses are in customer records: ");
    //     for (int i= 0; i<_address.Count; i++) {
    //         Console.Write($"{i+1} {_address[i].DisplayAddress()}");
    //     }
    // }
}