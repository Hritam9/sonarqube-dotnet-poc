using Xunit;
using MyApp;

namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Add(2, 3));
    }
}
