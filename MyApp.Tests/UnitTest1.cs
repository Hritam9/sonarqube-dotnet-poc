using Xunit;
using MyApp;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAdd()
        {
            var result = Calculator.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
