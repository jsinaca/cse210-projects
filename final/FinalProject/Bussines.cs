class Bussines {
    private string _name;
    private Inventory _inventory = new Inventory();
    private List<Customer> _customers = new List<Customer>();

    public Bussines(string name) {
        _name = name;
    }
    public void Run() {
        Console.WriteLine($"Welcome to {_name}");
        while (true) {
            string userOption = Menu();
            switch (userOption) {
                case "1": {
                    SubMenuInventory();
                    break;
                }
                case "2" : {
                    SubMenuCustomers();
                    break;
                }
                case "3" : {
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
    public void AddNewProduct(){
        _inventory.AddNewProduct();
    }
    public void AddQtyExistingProduct() {
        _inventory.AddQtyExistingProduct();
    }
    public void DisplayAllInventory() {

    }
    public void DisplayProduct(int barcode) {

    }
    public void DisplayProduct(string name) {}

    public void DisplayCustomersInfo() {

    }
    public void DisplayCustomerInfo(string fullname) {

    }
    public void DisplayCustomerInfo(int id) {

    }
    public string Menu() {
        Console.WriteLine("What would you like to do today?");
        Console.WriteLine("1. Inventory");
        Console.WriteLine("2. Customers");
        Console.WriteLine("3. Exit program");
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
        Console.WriteLine("8. Return to previous menu");

        string userOption = Console.ReadLine();
        //to do swirtch options 
        
    }
    public void SubMenuCustomers() {

    }
}