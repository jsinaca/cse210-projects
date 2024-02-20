class Product {
    private string _name;
    private int _barCode;
    private string _description;
    private int _qty;    
    public Product(string name, int barcode, string description, int qty) {
        _name = name;
        _barCode = barcode;
        _description = description;
        _qty = qty;
    }
    public void ChangeName(string newName){
        _name = newName;
    }
    public void ChangeBarcode(int newBarcode) {
        _barCode = newBarcode;
    }
    public void ChangeDescription(string newDescription) {
        _description = newDescription;
    }
    public void DisplayProductInfo() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"BarCode: {_barCode}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Quantity: {_qty}");
        Console.WriteLine();
    }
    public void DisplayQty() {
        Console.WriteLine($"The quantity of {_name} in the inventory is: {_qty}");
    }
    public string GetName() {
        return _name;
    }
    public int GetBarcode() {
        return _barCode;
    }
    public void AddQty(int addition) {
        _qty += addition;
    }
    public string GetStrignRepresentation() {
        return $"{_name},{_barCode},{_description},{_qty}";
    }
    
}