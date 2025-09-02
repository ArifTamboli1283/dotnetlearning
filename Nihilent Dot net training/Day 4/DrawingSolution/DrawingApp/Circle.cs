namespace Drawing;

public class Circle : Shape, IDisposal
{
    ~Circle() { }
    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public void calculateArea()
    {
        Area = Math.PI * Radius * Radius;
        Circumference = 2 * Math.PI * Radius;

    }
}