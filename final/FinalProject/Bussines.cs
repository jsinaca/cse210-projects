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
        LoadCustomers();
        while (true) {
            string userOption = Menu();
            switch (userOption) {
                case "1": {
                    SubMenuInventory();
                    _inventory.Save(_name);
                    break;
                }
                case "2" : {
                    SubMenuCustomers();
                    SaveCusotmers();
                    break;
                }
                case "3" : {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default : {
                    Console.WriteLine("Invalid input, Try again");
                    Thread.Sleep(2000);
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
        Console.Write("Selct an option: ");

        string userOption = Console.ReadLine();
        switch (userOption) {
            case "1" : {
                _inventory.AddNewProduct();
                Console.Clear();
                break;
            }
            case "2" : {
                _inventory.AddQtyExistingProduct();
                Console.Clear();
                break;
            }
            case "3" : {
                _inventory.ChangeName();
                Console.Clear();
                break;
            }
            case "4" : {
                _inventory.ChangeBarcode();
                Console.Clear();
                break;
            }
            case "5" : {
                _inventory.ChangeDescription();
                Console.Clear();
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
                Console.Clear();
                _inventory.DisplayInventory();
                break;
            }
            case "9" : {
                Console.Clear();
                break;
            }
            default : {
                Console.WriteLine("Invalid input");
                Thread.Sleep(2000);
                Console.Clear();
                break;
            }
        }
    }
    public void SubMenuCustomers() {
        Console.WriteLine("What would you like to do with the customers list? ");
        Console.WriteLine("1. Add new customer");
        Console.WriteLine("2. Modify first name (Exiting customer)");
        Console.WriteLine("3. Modify last name (Exiting customer)");
        Console.WriteLine("4. Modify address (Exiting customer)");
        Console.WriteLine("5. Modify day of birth (Exiting customer)");
        Console.WriteLine("6. Display all cutomers");
        Console.WriteLine("7. Return to previous menu");
        Console.Write("Select an option: ");

        string userOption = Console.ReadLine();
        switch (userOption) {
            case "1" : {
                AddCustomer();
                Console.Clear();
                break;
            }
            case "2" : {
                ModifyCustomerFistName();
                Console.Clear();
                break;
            }
            case "3" : {
                ModifyCustomerLastName();
                Console.Clear();
                break;
            }
            case "4" : {
                ModifyAddress();
                Console.Clear();
                break;
            }
            case "5" : {
                ModifyDOB();
                Console.Clear();
                break;
            }
            case "6" : {
                ShowAllCustomers();
                break;
            }
            case "7" : {
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
    }
    public int FindCustomer() {
        int userIndex = -1;
        Console.Write("What is the first and last name of the customer? ");
        string userInput = Console.ReadLine();
        string[] temp = userInput.Split(" ");

        userIndex = _customers.FindIndex(a => a.GetName() == temp[0] && a.GetLastName() == temp[1]);
        return userIndex;
    }
    private void AddCustomer() {
        try {
            Console.Write("What is the customer first name? ");
            string name = Console.ReadLine();
            Console.Write("What is the customer last name? ");
            string last = Console.ReadLine();
            Console.Write("What is the customer day of birth (MM/DD/YYYY)? ");
            string dob = Console.ReadLine();
            bool validateDOB = ValidateDOB(dob);
            Console.Write("What is the customer address? ");
            string address = Console.ReadLine();
            Console.Write("What is the customer zipcode? ");
            int zip = int.Parse(Console.ReadLine());
            Console.Write("What is the customer state? ");
            string state = Console.ReadLine();

            Address customerAddress;
            while (true) {
                Console.Write("Is that an apartament (yes/no)? ");
                string apt = Console.ReadLine();
                if (apt == "no") {
                    customerAddress = new HomeAddress(address, zip, state);
                    break;
                }
                else if (apt == "yes"){
                    Console.Write("What is your apartament number? ");
                    string aptNumber = Console.ReadLine();

                    customerAddress = new ApartamentAddress(address, zip,state, aptNumber);
                    break;
                }
                else {
                    Console.Write("Invalid answer, try again\n");
                }
            }
            if (validateDOB) {
                string[] dobTemp = dob.Split("/");
                DateOfBirth dateOfBirth = new DateOfBirth(dobTemp[0], dobTemp[1], dobTemp[2]);
                Customer customer = new Customer(name, last, customerAddress, dateOfBirth);
                _customers.Add(customer);
            }
            else {
                Console.Write("One or more inputs don't have the right format (invalid input)");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        catch (Exception e) {
            Console.WriteLine("Something went wrong, please verify your Address information and try again");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
    private void ModifyCustomerFistName() {
        int userIndex = FindCustomer();
        if (userIndex != -1) {
            Console.Write("What is the new name of the customer? ");
            string newName = Console.ReadLine();
            _customers[userIndex].ChangeFistName(newName);
        }
        else {
            Console.WriteLine("User not found");
        }
    }
    private void ModifyCustomerLastName() {
        int userIndex = FindCustomer();
        if (userIndex != -1) {
            Console.Write("What is the new last name of the customer? ");
            string newLastName = Console.ReadLine();
            _customers[userIndex].ChangeLastName(newLastName);
        }
        else {
            Console.WriteLine("User not found");
        }
    }
    private void ModifyAddress(){
        int userIndex = FindCustomer();
        if (userIndex != -1) {
            _customers[userIndex].ModifyAddress();
        }
        else {
            Console.WriteLine("User not found");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
    private void ModifyDOB(){
        int userIndex = FindCustomer();
        if (userIndex != -1) {
            _customers[userIndex].ChangeDOB();
        }
    }
    private void ShowAllCustomers() {
        Console.WriteLine("The folloing is the information of the customer in our database");
        int count = 1;
        foreach (Customer customer in _customers) {
            Console.WriteLine();
            Console.Write($"{count}. ");
            customer.DisplayCustomerInfo();
            Console.WriteLine();
        }
    }
    private static bool ValidateDOB(string dob) {
        string[] split = dob.Split("/");
        if (split.Count() == 3) {
            if (split[0].Count() == 2 && split[1].Count() == 2 && split[2].Count() == 4) {
                if (int.Parse(split[0]) >= 1 && int.Parse(split[1]) >= 1 && int.Parse(split[2]) >= 1900) {   
                    return true; 
                }
                return false;
            }
            return false;
        }
        else {
            Console.WriteLine("Invalid format");
            return false;
        }
    }
    private void SaveCusotmers() {
        string fileName = $"{_name}Customers.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            outputFile.WriteLine($"{fileName}");
            foreach (Customer customer in _customers) {
                outputFile.WriteLine($"{customer.GetStrignRepresentation()}");
            }   
        }
    }
    private void LoadCustomers() {
        if (File.Exists($"{Directory.GetCurrentDirectory()}/{_name}Customers.txt")) {
            List<string> lines = new List<string>(File.ReadAllLines($"{_name}Customers.txt"));
            lines.RemoveAt(0);
            
            foreach (string line in lines) {
                string[] parts = line.Split(",");
                if (parts.Count() == 6) {
                    string[] subPartDOB = parts[2].Split("/"); 
                    DateOfBirth dateOfBirth = new DateOfBirth(subPartDOB[0], subPartDOB[1], subPartDOB[2]);
                    string[] subPArtAddress = parts[3].Split(":");
                    Address address;
                    if (subPArtAddress[0] == "HomeAddress") {
                        address = new HomeAddress(subPArtAddress[1], int.Parse(parts[4]), parts[5]);
                        AddCustomerFromFile(parts[0], parts[1], address, dateOfBirth);
                    }
                    else if (subPArtAddress[0] == "ApartamentAddress") {
                        address = new ApartamentAddress(subPArtAddress[1], int.Parse(parts[4]), parts[5], parts[6]);
                        AddCustomerFromFile(parts[0], parts[1], address, dateOfBirth);
                    }
                }
            }
        }
    }
    private void AddCustomerFromFile(string name, string last, Address address, DateOfBirth dateOfBirth) {
        Customer temp = new Customer(name, last, address, dateOfBirth);
        _customers.Add(temp);
    }
}