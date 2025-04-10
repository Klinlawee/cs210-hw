// Shape.cs
public abstract class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Get and Set Color
    public string GetColor() => _color;
    public void SetColor(string color) => _color = color;

    // Abstract Method
    public abstract double GetArea();
}
