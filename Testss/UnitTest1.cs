using Math;
using Math.Interfaces;
using Math.Models;
using Xunit;

namespace Testss;

public class UnitTest1f
{
    [Theory]
    [InlineData(10,62)]
    [InlineData(20,125)]
    public void CalculateAreaOfCircleByRadius(int radius,int expected)
    {
        //arrange
        ICalculableArea figure = new Circle(radius);
        //act
        var result = figure.Calculate();
        //assert
        Assert.Equal(expected, (int)result);
    }

    [Theory]
    [InlineData(3,4,5,6)]
    [InlineData(20,30,40,290)]
    public void CalculateAreaOfTriangleByThreeSides(double firstSide,double secondSide,double thirdSide,double expected)
    {
        //arrange
        ICalculableArea figure = new Triangle(firstSide,secondSide,thirdSide);
        //act
        var result = figure.Calculate();
        //assert
        Assert.Equal(expected,(int)result);
    }

    [Theory]
    [InlineData(3,4,5,true)]
    [InlineData(10,20,35,false)]
    public void TriangleShouldBeRectangular(double firstSide,double secondSide,double thirdSide,bool triangleRectangular)
    {
        //arrange
        ICheckRectangularTriangle figure = new Triangle(firstSide, secondSide, thirdSide);
        //act
        var result = figure.TriangleRectangular();
        //assert
        Assert.Equal(triangleRectangular,result);
    }
}
