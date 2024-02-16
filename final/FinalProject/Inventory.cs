class Inventory {
    private List<Product> _products ;

    public Inventory() {}
    public string InStock() {
        return "";
    }
    public List<string> FullInventoryProduct() {
        return new List<string>();
    }
    public void DisplayInventory() {

    }
    public void DisplayProduct(string product) {

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
    }
    public void AddQtyExistingProduct() {
        
    }
    public void RemoveProduct() {

    }
    public void Save() {

    }
    public void Load() {

    }

}