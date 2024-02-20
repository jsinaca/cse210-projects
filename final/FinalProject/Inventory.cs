class Inventory {
    private List<Product> _products = new List<Product>();

    public Inventory() {}
  
    public void DisplayInventory() {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Full inventory");
        foreach (Product product in _products) {
            product.DisplayProductInfo();
        }
    }
    public void AddNewProduct() {
        Console.Write("What is the name of the product? ");
        string name = Console.ReadLine();
        Console.Write("Add a breaf description of product ");
        string description = Console.ReadLine();
        try {
            Console.Write("What is the barcode of the product? ");
            int barcode = int.Parse(Console.ReadLine());
            Console.Write("What is the quantity? ");
            int qty = int.Parse(Console.ReadLine());

            Product product = new Product(name, barcode, description, qty);
            _products.Add(product);
        }
        catch (Exception e) {
            Console.WriteLine("Something went wrong. Please verify your barcode and product quantity and try again");
        }
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
            IfProductNoFound(product);
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
            IfProductNoFound(product);
        }
    }
    public void ChangeBarcode() {
        try {
            Console.Write("What is the barcode of the product you want to change? ");
            int userInput = int.Parse(Console.ReadLine());
            foreach (Product product in _products) {
                if (product.GetBarcode() == userInput) {
                    Console.Write("What is the new barcode of the product? ");
                    int newName = int.Parse(Console.ReadLine());
                    product.ChangeBarcode(newName);
                    break;
                }
                IfProductNoFound(product);
            }
        }
        catch (Exception e) {
            Console.WriteLine("Barcode not found. Please verify barcode\n");
            Thread.Sleep(2000);
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
            IfProductNoFound(product);
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
            IfProductNoFound(product);
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
    public void Save(string name) {
        using (StreamWriter outputFile = new StreamWriter($"{name}Inventory.txt")) {
            outputFile.WriteLine($"{name}Inventory.txt");
            foreach (Product product in _products) {
                outputFile.WriteLine($"{product.GetStrignRepresentation()}");
            }   
        }
    }
    public void Load(string name) {
        if (File.Exists($"{Directory.GetCurrentDirectory()}/{name}Inventory.txt")) {
            List<string> lines = new List<string>(File.ReadAllLines($"{name}Inventory.txt"));
            lines.RemoveAt(0);
            
            foreach (string line in lines) {
                string[] parts = line.Split(",");
                Product temp = new Product(parts[0], int.Parse(parts[1]), parts[2], int.Parse(parts[3]));
                _products.Add(temp);
            }
        }
    }
    private void IfProductNoFound(Product product) {
        if (product == _products[_products.Count()-1]) {
            Console.WriteLine("Product not found");
            Console.WriteLine("");
        }
    }
}