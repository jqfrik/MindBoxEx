using Math.Interfaces;

namespace Math.Models;

public class Triangle : ICalculableArea,ICheckRectangularTriangle
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    public Triangle(double firstSide, double secondSide,double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }
    public double Calculate()
    {
        var perimeter = (_firstSide + _secondSide + _thirdSide ) / 2;
        return System.Math.Sqrt(perimeter * (perimeter - _firstSide) * (perimeter - _secondSide) * (perimeter - _thirdSide));
    }

    public bool TriangleRectangular()
    {
        return (int)(System.Math.Pow(_firstSide, 2) + System.Math.Pow(_secondSide, 2)) == (int)System.Math.Pow(_thirdSide, 2);
    }
}