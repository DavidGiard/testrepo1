using TestRepo1;

namespace TestRepo1.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSum()
    {
        decimal result = AdditionCalculator.Add(12.5m, 7.25m);

        Assert.Equal(19.75m, result);
    }

    [Fact]
    public void Add_WithNegativeNumber_ReturnsSum()
    {
        decimal result = AdditionCalculator.Add(-10m, 4m);

        Assert.Equal(-6m, result);
    }

    [Fact]
    public void Multiply_ReturnsProduct()
    {
        decimal result = MultiplicationCalculator.Multiply(2.5m, 4m);

        Assert.Equal(10m, result);
    }

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        decimal result = MultiplicationCalculator.Multiply(42m, 0m);

        Assert.Equal(0m, result);
    }

    [Fact]
    public void Subtract_ReturnsDifference()
    {
        decimal result = SubtractionCalculator.Subtract(10m, 4m);

        Assert.Equal(6m, result);
    }
}
