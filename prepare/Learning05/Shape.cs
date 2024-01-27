public abstract class Shape {
    string _color;
    public Shape (string color) {
        _color = color;
    }

    public string GetColor(){
        return _color;
    }
    public void SetColor() {

    }
    public abstract double GetArea();
}