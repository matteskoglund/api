using Xunit;
using TodoApi.Controllers;

namespace test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dotnet-core.html
    public class ValuesControllersTest
    {
        private readonly ValuesController _valuesController;
        public ValuesControllersTest()
        {
            _valuesController = new ValuesController();
        }

        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
