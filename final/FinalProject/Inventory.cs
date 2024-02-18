class Inventory {
    private List<Product> _products = new List<Product>();

    public Inventory() {}
  
    public void DisplayInventory() {
        Console.Clear();
        Console.WriteLine("Full inventory");
        foreach (Product product in _products) {
            product.DisplayProductInfo();
        }
    }
    public void AddNewProduct() {
        Console.Write("What is the name of the product? ");
        string name = Console.ReadLine();
        Console.Write("What is the barcode of the product? ");
        int barcode = int.Parse(Console.ReadLine());
        Console.Write("Add a breaf description of product ");
        string description = Console.ReadLine();
        Console.Write("What is the quantity? ");
        int qty = int.Parse(Console.ReadLine());

        Product product = new Product(name, barcode, description, qty);
        _products.Add(product);
    }
    public void AddQtyExistingProduct() {
        Console.Write("What is the name of the product? ");
        string userInput = Console.ReadLine();
        foreach (Product product in _products) {
            if (product.GetName() == userInput) {
                Console.Write("What is the quantity you want to add? ");
                int addQty = int.Parse(Console.ReadLine());
                product.AddQty(addQty);
                break;
            }
        }
    }
    public void ChangeName() {
        Console.Write("What is the name of the product you want to change? ");
        string userInput = Console.ReadLine();
        foreach (Product product in _products) {
            if (product.GetName() == userInput) {
                Console.Write("What is the new name of the product? ");
                string newName = Console.ReadLine();
                product.ChangeName(newName);
                break;
            }
        }
    }
    public void ChangeBarcode() {
        Console.Write("What is the barcode of the product you want to change? ");
        int userInput = int.Parse(Console.ReadLine());
        foreach (Product product in _products) {
            if (product.GetBarcode() == userInput) {
                Console.Write("What is the new barcode of the product? ");
                int newName = int.Parse(Console.ReadLine());
                product.ChangeBarcode(newName);
                break;
            }
        }
    }
    public void ChangeDescription() {
        Console.Write("What is the name of the product you want to change the description? ");
        string userInput = Console.ReadLine();
        foreach (Product product in _products) {
            if (product.GetName() == userInput) {
                Console.Write("What is the new descrition of the product? ");
                string newName = Console.ReadLine();
                product.ChangeDescription(newName);
                break;
            }
        }
    }
    public void DisplayProductInfo() {
        Console.Write("What is the name of the product you want to know? ");
        string userInput = Console.ReadLine();
        foreach (Product product in _products) {
            if (product.GetName() == userInput) {
                Console.WriteLine("Product information");
                product.DisplayProductInfo();
                break;
            }
        }
    }
    public void DisplayQty() {
        Console.Write("What is the name of the product you want know? ");
        string userInput = Console.ReadLine();
        foreach (Product product in _products) {
            if (product.GetName() == userInput) {
                product.DisplayQty();
                break;
            }
        }
    }
    // public void RemoveProduct() {

    // }
    public void Save(string name) {
        using (StreamWriter outputFile = new StreamWriter(name)) {
            outputFile.WriteLine($"{name}");
            foreach (Product product in _products) {
                outputFile.WriteLine($"{product.GetStrignRepresentation()}");
            }   
        }
        Console.Clear();
    }
    public void Load(string name) {
        if (File.Exists($"{Directory.GetCurrentDirectory()}/{name}")) {
            List<string> lines = new List<string>(File.ReadAllLines(name));
            lines.RemoveAt(0);
            
            foreach (string line in lines) {
                string[] parts = line.Split(",");
                Product temp = new Product(parts[0], int.Parse(parts[1]), parts[2], int.Parse(parts[3]));
                _products.Add(temp);
            }
        }
    }
}