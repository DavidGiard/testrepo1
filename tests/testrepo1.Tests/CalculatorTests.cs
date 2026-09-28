using TestRepo1;

namespace TestRepo1.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSumOfTwoNumbers()
    {
        decimal result = Calculator.Add(2m, 3m);

        Assert.Equal(5m, result);
    }
}