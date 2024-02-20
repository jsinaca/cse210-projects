class Customer {
    private string _firstName;
    private string _lastName;
    private  Address _address;
    private DateOfBirth _dob; 
    public Customer(string name, string last, Address address, DateOfBirth dob) {
        _firstName = name;
        _lastName = last;
        _dob = dob;
        _address = address;
    }
    public void DisplayCustomerInfo() {
        Console.WriteLine($"First name: {_firstName}");
        Console.WriteLine($"Last Name: {_lastName}");
        _address.DisplayAddress();
        _dob.DisplayDOB();
    }
    public void AddAddress(Address address) {
        _address = address;
    }
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
                try {
                    Console.Write("What is the new zipcode? ");
                    int newZipcode = int.Parse(Console.ReadLine());
                    _address.ChangeZip(newZipcode);
                    break;
                }
                catch (Exception e) {
                    Console.WriteLine("Invalid input");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
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
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }
        }
    }
    public void ChangeDOB() {
        Console.WriteLine("What would you like to modify from the user? ");
        Console.WriteLine("1. Month");
        Console.WriteLine("2. Day");
        Console.WriteLine("3. Year");
        Console.WriteLine("Select an option: ");
        string useroption = Console.ReadLine();
        switch (useroption) {
            case "1" : {
                Console.Write("What it the new month (MM)? ");
                string newMonth = Console.ReadLine();
                _dob.ChangeMonth(newMonth);
                break;
            }
            case "2" : {
                Console.Write("What it the new day (DD)? ");
                string newDay = Console.ReadLine();
                _dob.ChangeDay(newDay);
                break;
            }
            case "3" : {
                Console.Write("What it the new year (YYYY)? ");
                string newYear = Console.ReadLine();
                _dob.ChangeDay(newYear);
                break;
            }
            default : {
                Console.Write("Invalid input");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
        }
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
    public string GetStrignRepresentation() {
        return $"{_firstName},{_lastName},{_dob.GetStrignRepresentation()},{_address.GetStrignRepresentation()}";
    }
}