class Bussines {
    private string _name;
    private Inventory _inventory = new Inventory();
    private List<Customer> _customers = new List<Customer>();

    public Bussines(string name) {
        _name = name;
        Run();
    }
    public void Run() {
        Console.WriteLine($"Welcome to {_name}");
        _inventory.Load(_name);
        while (true) {
            string userOption = Menu();
            switch (userOption) {
                case "1": {
                    // Console.Clear();
                    SubMenuInventory();
                    _inventory.Save(_name);
                    break;
                }
                case "2" : {
                    // Console.Clear();
                    SubMenuCustomers();
                    break;
                }
                case "3" : {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default : {
                    Console.WriteLine("Invalid input, try again");
                    Thread.Sleep(5000);
                    Console.Clear();
                    break;
                }
            }
        }
    }
    public string Menu() {
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("1. Inventory");
        Console.WriteLine("2. Customers");
        Console.WriteLine("3. Exit program");
        Console.Write("Select an option: ");
        string userOption = Console.ReadLine();
        return userOption;
    }
    public void SubMenuInventory() {
        Console.WriteLine("What would you like to do in the Inventory? ");
        Console.WriteLine("1. Add new product ");
        Console.WriteLine("2. Add quantity (Exiting product)");
        Console.WriteLine("3. Modify Product name (Exiting product)");
        Console.WriteLine("4. Modify Product barcode (Exiting product)");
        Console.WriteLine("5. Modify Product description (Exiting product)");
        Console.WriteLine("6. Display product information (Exiting product)");
        Console.WriteLine("7. Display product quantity (Exiting product)");
        Console.WriteLine("8. Display full inventory");
        Console.WriteLine("9. Return to previous menu");

        string userOption = Console.ReadLine();
        switch (userOption) {
            case "1" : {
                _inventory.AddNewProduct();
                break;
            }
            case "2" : {
                _inventory.AddQtyExistingProduct();
                break;
            }
            case "3" : {
                _inventory.ChangeName();
                break;
            }
            case "4" : {
                _inventory.ChangeBarcode();
                break;
            }
            case "5" : {
                _inventory.ChangeDescription();
                break;
            }
            case "6" : {
                _inventory.DisplayProductInfo();
                break;
            }
            case "7" : {
                _inventory.DisplayQty();
                break;
            }
            case "8" : {
                _inventory.DisplayInventory();
                break;
            }
            case "9" : {
                Console.Clear();
                break;
            }
            default : {
                Console.WriteLine("Invalid input, try again");
                Thread.Sleep(5000);
                Console.Clear();
                break;
            }
        }
        Console.Clear();
    }
    public void SubMenuCustomers() {
        Console.WriteLine("What would you like to do with the customers list? ");
        Console.WriteLine("1. Add new customer");
        Console.WriteLine("2. Modify first name (Exiting customer)");
        Console.WriteLine("3. Modify last name (Exiting customer)");
        Console.WriteLine("4. Add address (Exiting customer)");
        Console.WriteLine("5. Modify address (Exiting customer)");
        Console.WriteLine("6. Modify day of birth (Exiting customer)");
        // Console.WriteLine("7. Add payment method (Exiting customer)");
        Console.WriteLine("7. Add phone number (Exiting customer)");
        Console.WriteLine("8. Modify  phone number (Exiting customer)");
        Console.WriteLine("9. Display all cutomers");
        Console.WriteLine("10. Return to previous menu");

        string userOption = Console.ReadLine();
        switch (userOption) {
            case "1" : {
                Console.Write("What is the customer first name ");
                string name = Console.ReadLine();
                Console.Write("What is the customer last name ");
                string last = Console.ReadLine();
                Console.Write("What is the customer day of birth (MM/DD/YYYY)? ");
                string dob = Console.ReadLine();
                Console.Write("What is the customer address? ");
                string address = Console.ReadLine();
                Console.Write("What is the customer zipcode? ");
                int zip = int.Parse(Console.ReadLine());
                Console.Write("What is the customer state? ");
                string state = Console.ReadLine();
                Console.Write("Is that an apartament? ");
                string apt = Console.ReadLine();

                Address customerAddress;
                if (apt == "no") {
                    customerAddress = new HomeAddress(address, zip, state);
                }
                else {
                    Console.Write("What is your apartament number? ");
                    string aptNumber = Console.ReadLine();

                    customerAddress = new ApartamentAddress(address, zip,state, aptNumber);
                }
                string[] dobTemp = dob.Split("/");
                DateOfBirth dateOfBirth = new DateOfBirth(dobTemp[0], dobTemp[1], dobTemp[2]);
                Customer customer = new Customer(name, last, customerAddress, dateOfBirth);
                
                _customers.Add(customer);
                break;
            }
            case "2" : {
                int userIndex = FindCustomer();
                if (userIndex != -1) {
                    Console.Write("What is the new name of the customer? ");
                    string newName = Console.ReadLine();
                    _customers[userIndex].ChangeFistName(newName);
                }
                else {
                    Console.WriteLine("User not found");
                }
                break;
            }
            case "3" : {
                int userIndex = FindCustomer();
                if (userIndex != -1) {
                    Console.Write("What is the new last name of the customer? ");
                    string newLastName = Console.ReadLine();
                    _customers[userIndex].ChangeLastName(newLastName);
                }
                else {
                    Console.WriteLine("User not found");
                }
                break;
            }
            case "4" : {
                int userIndex = FindCustomer();
                if (userIndex != -1) {
                    Console.Write("What is the customer address? ");
                    string address = Console.ReadLine();
                    Console.Write("What is the customer zipcode? ");
                    int zip = int.Parse(Console.ReadLine());
                    Console.Write("What is the customer state? ");
                    string state = Console.ReadLine();
                    Console.Write("Is that an apartament? ");
                    string apt = Console.ReadLine();
                    
                    Address customerAddress;
                    if (apt == "no") {
                        customerAddress = new HomeAddress(address, zip, state);
                    }
                    else {
                        Console.Write("What is your apartament number? ");
                        string aptNumber = Console.ReadLine();

                        customerAddress = new ApartamentAddress(address, zip,state, aptNumber);
                    }
                    _customers[userIndex].AddAddress(customerAddress);
                }
                else {
                    Console.WriteLine("User not found");
                }
                break;
            }
            case "5" : {
                int userIndex = FindCustomer();
                if (userIndex != -1) {
                    // _customers[userIndex].DisplayAddresses();
                    // Console.Write("What address would you like to modify? ");
                    // int userChange = int.Parse(Console.ReadLine());
                    // _customers[userIndex].ModifyAddress(userChange-1);
                    _customers[userIndex].ModifyAddress();
                }
                else {
                    Console.WriteLine("User not found");
                }
                break;
            }
            case "6" : {
                int userIndex = FindCustomer();
                if (userIndex != -1) {
                    _customers[userIndex].ChangeDOB();
                }
                break;
            }
            // case "7" : {
            //     int userIndex = FindCustomer();
            //     if (userIndex != -1) {
            //         _customers[userIndex].AddPaymentInformation();
            //     }
            //     break;
            // }
            case "7" : {
                // _customers;
                break;
            }
            case "8" : {
                // _customers;
                break;
            }
            case "9" : {
                // _customers;
                break;
            }
            case "10" : {
                Console.Clear();
                break;
            }
            default : {
                Console.WriteLine("Invalid input, try again");
                Thread.Sleep(5000);
                Console.Clear();
                break;
            }
        }
        Console.Clear();
    }
    public int FindCustomer() {
        int userIndex = -1;
        Console.Write("What is the first and last name of the customer? ");
        string userInput = Console.ReadLine();
        string[] temp = userInput.Split(" ");

        userIndex = _customers.FindIndex(a => a.GetName() == temp[0] && a.GetLastName() == temp[1]);
        return userIndex;
    }
}