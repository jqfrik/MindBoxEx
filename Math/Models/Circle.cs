using Math.Interfaces;

namespace Math.Models;

public class Circle : ICalculableArea
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }
    public double Calculate()
    {
        return 2 * System.Math.PI * _radius;
    }
}